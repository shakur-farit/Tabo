using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Code.Infrastructure.AssetManagement
{
  public class AssetProvider : IAssetProvider
  {
	  private readonly Dictionary<string, AsyncOperationHandle> _completedCache = new();
		private readonly Dictionary<string, List<AsyncOperationHandle>> _handles = new();

		public async UniTask Initialize() => await Addressables.InitializeAsync().ToUniTask();

		public async UniTask<T> Load<T>(string addressReference) where T : class
		{
			if (_completedCache.TryGetValue(addressReference, out AsyncOperationHandle cachedHandle))
				return cachedHandle.Result as T;

			AsyncOperationHandle<T> handle = Addressables.LoadAssetAsync<T>(addressReference);

			AddHandle(addressReference, handle);

			try
			{
				T result = await handle.ToUniTask();
				_completedCache[addressReference] = handle;
				return result;
			}
			catch (Exception e)
			{
				Debug.LogError($"Failed to load asset {addressReference}: {e.Message}");
				_handles[addressReference].Remove(handle);
				Addressables.Release(handle);
				throw;
			}
		}

		public void Preload<T>(string addressReference) where T : class
		{
			if (_completedCache.ContainsKey(addressReference))
				return;

			AsyncOperationHandle<T> handle = Addressables.LoadAssetAsync<T>(addressReference);
			_completedCache[addressReference] = handle;

			AddHandle(addressReference, handle);

			handle.Completed += h =>
			{
				if (h.Status == AsyncOperationStatus.Succeeded)
				{
					_completedCache[addressReference] = h;
				}
				else
				{
					Debug.LogError($"Preloading asset {addressReference} failed.");
					_completedCache.Remove(addressReference);
					_handles[addressReference].Remove(h);
					Addressables.Release(h);
				}
			};
		}

		public void Release(string addressReference)
		{
			if (_completedCache.TryGetValue(addressReference, out AsyncOperationHandle handle))
			{
				Addressables.Release(handle);
				_completedCache.Remove(addressReference);
			}

			if (_handles.TryGetValue(addressReference, out List<AsyncOperationHandle> resourceHandles))
			{
				foreach (AsyncOperationHandle h in resourceHandles)
					Addressables.Release(h);

				_handles.Remove(addressReference);
			}
		}

		public void CleanUp()
		{
			foreach (List<AsyncOperationHandle> resourcesHandles in _handles.Values)
				foreach (AsyncOperationHandle handle in resourcesHandles)
					Addressables.Release(handle);

			_completedCache.Clear();
			_handles.Clear();
		}

		private void AddHandle<T>(string key, AsyncOperationHandle<T> handle) where T : class
		{
			if (!_handles.TryGetValue(key, out List<AsyncOperationHandle> resourceHandles))
			{
				resourceHandles = new List<AsyncOperationHandle>();
				_handles[key] = resourceHandles;
			}

			resourceHandles.Add(handle);
		}
	}
}