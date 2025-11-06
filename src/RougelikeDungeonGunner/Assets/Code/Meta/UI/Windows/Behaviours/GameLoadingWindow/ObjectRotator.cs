using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class ObjectRotator : MonoBehaviour
	{
		[SerializeField] private Transform _rotatingTransform;
		[SerializeField] private Vector3 _rotationSpeed = new(0f, 0f, 100f);

		private void Update() => 
			Rotate();

		private void Rotate()
		{
			if (_rotatingTransform != null)
				_rotatingTransform.Rotate(_rotationSpeed * Time.deltaTime);
		}
	}
}