using System.Collections;
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

		public void AnimateReloading(float reloadTimeLeft, float reloadTime)
		{
			_relaodingBar.localScale = new Vector3(0,1,1);

			StartCoroutine(ReloadCoroutine(reloadTimeLeft, reloadTime));
		}

		private IEnumerator ReloadCoroutine(float reloadTimeLeft, float reloadTime)
		{
			StartAnimateReloadText();

			_relaodingBarImage.color = Color.red;

			float elapsed = reloadTime - reloadTimeLeft;

			while (elapsed < reloadTime)
			{
				float progress = Mathf.Clamp01(elapsed / reloadTime);
				_relaodingBar.localScale = new Vector3(progress * _originalScale.x, _originalScale.y, _originalScale.z);

				yield return null;
				elapsed += Time.deltaTime;
			}

			_relaodingBar.localScale = _originalScale;
			_relaodingBarImage.color = Color.green;

			StopAnimateReloadText();
		}

		private void StartAnimateReloadText() => 
			_reloadingTextCanvas.gameObject.SetActive(true);

		private void StopAnimateReloadText() =>
			_reloadingTextCanvas.gameObject.SetActive(false);
	}
}