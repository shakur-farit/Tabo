using System.Collections.Generic;
using Code.Meta.UI.Hud.AmmoHolder.Factory;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Hud.AmmoHolder.Behaviours
{
	public class AmmoHolderBehaviour : MonoBehaviour
	{
		[SerializeField] private Transform _holder;

		private readonly List<GameObject> _bulletIconsBuffer = new();

		private IAmmoUIFactory _factory;

		[Inject]
		public void Constructor(IAmmoUIFactory factory) =>
			_factory = factory;

		public async void UpdateAmmoUICount(int currentCount)
		{
			await CreateAmmoUI(currentCount);

			for (int i = 0; i < _bulletIconsBuffer.Count; i++)
				_bulletIconsBuffer[i].SetActive(i < currentCount);
		}

		private async UniTask CreateAmmoUI(int requiredCount)
		{
			while (_bulletIconsBuffer.Count < requiredCount)
			{
				GameObject icon = await _factory.CreateAmmoUI(_holder);
				icon.SetActive(false);
				_bulletIconsBuffer.Add(icon);
			}
		}
	}
}