using UnityEngine;

namespace Assets.Code.Gameplay.Features.Weapon.Behavours
{
	public class WeaponScaleNormalizer : MonoBehaviour
	{
		private void Start() => 
			transform.localScale = Vector3.one;
	}
}