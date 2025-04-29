using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.UI.Hud.WeaponHolder.Behaviours
{
	public class ReloadingAnimator : MonoBehaviour
	{
		[SerializeField] private CanvasGroup _reloadingTextCanvas;
		[SerializeField] private Transform _relaodingBar;
		[SerializeField] private Image _relaodingBarImage;

		private Tween _reloadBlinkTween;
		private Tween _reloadBarTween;

		private void Awake()
		{
			_reloadingTextCanvas.gameObject.SetActive(false);
			_relaodingBar.localScale = Vector3.one;

			_relaodingBarImage.type = Image.Type.Filled;
			_relaodingBarImage.fillMethod = Image.FillMethod.Horizontal;
			_relaodingBarImage.fillAmount = 1f;
			_relaodingBarImage.color = Color.green;
		}

		public void StartAnimateReloadText()
		{
			_reloadingTextCanvas.gameObject.SetActive(true);

			_reloadBlinkTween?.Kill();

			_reloadingTextCanvas.alpha = 1f;
			_reloadBlinkTween = _reloadingTextCanvas.DOFade(0f, 0.5f)
				.SetLoops(-1, LoopType.Yoyo)
				.SetEase(Ease.Linear);
		}

		public void StopAnimateReloadText()
		{
			_reloadBlinkTween?.Kill();
			_reloadingTextCanvas.alpha = 1f;
			_reloadingTextCanvas.gameObject.SetActive(false);
		}

		public void StartReloadingBarAnimation(float value)
		{
			_reloadBarTween?.Kill();

			_relaodingBarImage.color = Color.red;
			_relaodingBarImage.fillAmount = 0f;

			_reloadBarTween = DOTween.To(() => _relaodingBarImage.fillAmount,
					x => _relaodingBarImage.fillAmount = x,
					1f,
					value)
				.SetEase(Ease.Linear);
		}

		public void StopReloadingBarAnimation()
		{
			_reloadBarTween?.Kill();
			_relaodingBarImage.fillAmount = 1f;
			_relaodingBarImage.color = Color.green;
		}
	}
}