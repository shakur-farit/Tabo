using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Registrars
{
	public class WeaponScaleNormalizer : MonoBehaviour
	{
		private void Start() => 
			transform.localScale = Vector3.one;
	}
}