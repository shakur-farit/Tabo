using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.Features.Hud.WeaponHolder.Behaviours
{
	public class ReloadingAnimator : MonoBehaviour
	{
		[SerializeField] private CanvasGroup _reloadingTextCanvas;
		[SerializeField] private Transform _relaodingBar;
		[SerializeField] private Image _relaodingBarImage;

		private Vector3 _originalScale;
		private CancellationTokenSource _cts;

		private void Awake()
		{
			_reloadingTextCanvas.gameObject.SetActive(false);
			_relaodingBar.localScale = Vector3.one;
			_originalScale = _relaodingBar.localScale;

			_relaodingBarImage.color = Color.green;
		}

		private void OnDestroy() => 
			CancelOngoingAnimation();

		public void AnimateReloading(float reloadTimeLeft, float reloadTime)
		{
			ResetCancellationToken();
			StartAnimateReloadText();

			_ = AnimateReloadingAsync(reloadTimeLeft, reloadTime, _cts.Token);
		}

		public void AnimatePrecharging(float reloadTimeLeft, float reloadTime)
		{
			ResetCancellationToken();
			_ = AnimateReloadingAsync(reloadTimeLeft, reloadTime, _cts.Token);
		}

		private async UniTask AnimateReloadingAsync(float reloadTimeLeft, float reloadTime, CancellationToken token)
		{
			try
			{
				_relaodingBar.localScale = new Vector3(0, 1, 1);
				_relaodingBarImage.color = Color.red;

				float elapsed = reloadTime - reloadTimeLeft;

				while (elapsed < reloadTime)
				{
					token.ThrowIfCancellationRequested();

					float progress = Mathf.Clamp01(elapsed / reloadTime);
					_relaodingBar.localScale = new Vector3(progress * _originalScale.x, _originalScale.y, _originalScale.z);

					await UniTask.Yield(PlayerLoopTiming.Update, token);
					elapsed += Time.deltaTime;
				}

				_relaodingBar.localScale = _originalScale;
				_relaodingBarImage.color = Color.green;
			}
			catch (OperationCanceledException)
			{
			}
			finally
			{
				if (this != null && _reloadingTextCanvas != null)
					StopAnimateReloadText();
			}
		}

		private void ResetCancellationToken()
		{
			CancelOngoingAnimation();
			_cts = new CancellationTokenSource();
		}

		private void CancelOngoingAnimation()
		{
			_cts?.Cancel();
			_cts?.Dispose();
			_cts = null;
		}

		private void StartAnimateReloadText() =>
				_reloadingTextCanvas.gameObject.SetActive(true);

		private void StopAnimateReloadText() =>
				_reloadingTextCanvas.gameObject.SetActive(false);
	}
}