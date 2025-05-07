using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.UI.Hud.WeaponHolder.Behaviours
{
	public class ReloadingAnimator : MonoBehaviour
	{
		[SerializeField] private CanvasGroup _reloadingTextCanvas;
		[SerializeField] private Transform _relaodingBar;
		[SerializeField] private Image _relaodingBarImage;

		private Vector3 _originalScale;

		private void Awake()
		{
			_reloadingTextCanvas.gameObject.SetActive(false);
			_relaodingBar.localScale = Vector3.one;
			_originalScale = _relaodingBar.localScale;

			_relaodingBarImage.color = Color.green;
		}

		public async void AnimateReloading(float reloadTimeLeft, float reloadTime)
		{
			_relaodingBar.localScale = new Vector3(0, 1, 1);

			StartAnimateReloadText();

			try
			{
				await ReloadAsync(reloadTimeLeft, reloadTime);
			}
			catch (OperationCanceledException)
			{
				Debug.Log("Weapon holder was destroyed");
			}

			StopAnimateReloadText();
		}

		public async void AnimatePrecharging(float reloadTimeLeft, float reloadTime)
		{
			_relaodingBar.localScale = new Vector3(0, 1, 1);

			try
			{
				await ReloadAsync(reloadTimeLeft, reloadTime);
			}
			catch (OperationCanceledException)
			{
				Debug.Log("Weapon holder was destroyed");
			}
		}

		private async UniTask ReloadAsync(float reloadTimeLeft, float reloadTime)
		{
			_relaodingBarImage.color = Color.red;

			float elapsed = reloadTime - reloadTimeLeft;

			CancellationToken token = this.GetCancellationTokenOnDestroy();

			while (elapsed < reloadTime)
			{
				float progress = Mathf.Clamp01(elapsed / reloadTime);
				_relaodingBar.localScale = new Vector3(progress * _originalScale.x, _originalScale.y, _originalScale.z);

				await UniTask.Yield(PlayerLoopTiming.Update, token);
				elapsed += Time.deltaTime;
			}

			_relaodingBar.localScale = _originalScale;
			_relaodingBarImage.color = Color.green;
		}

		private void StartAnimateReloadText() => 
			_reloadingTextCanvas.gameObject.SetActive(true);

		private void StopAnimateReloadText() =>
			_reloadingTextCanvas.gameObject.SetActive(false);
	}
}