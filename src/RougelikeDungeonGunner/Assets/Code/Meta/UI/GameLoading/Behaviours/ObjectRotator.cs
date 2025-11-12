using DG.Tweening;
using UnityEngine;

namespace Code.Meta.UI.GameLoading.Behaviours
{
	public class ObjectRotator : MonoBehaviour
	{
		[SerializeField] private Transform _rotatingTransform;
		[SerializeField] private Vector3 _endValue;
		[SerializeField] private float _duration;

		private Tween _rotationTween;

		private void OnDestroy()
		{
			if (_rotationTween != null && _rotationTween.IsActive()) 
				_rotationTween.Kill();
		}

		public void Rotate()
		{
      _rotationTween = _rotatingTransform
        .DORotate(_endValue, _duration, RotateMode.FastBeyond360)
        .SetRelative(true)
        .SetEase(Ease.Linear)
        .SetLoops(-1, LoopType.Restart)
        .SetUpdate(true);
    }
	}
}