using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Weapon;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Behaviours
{
	public class WeaponChanger : MonoBehaviour
	{
		private void Update()
		{
			if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha1))
			{
				CreateEntity.Empty()
					.AddWeaponChangeRequest(WeaponTypeId.Pistol)
					.With(x => x.isReadyToChangeWeapon = true)
					;
			}
			else if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha2))
			{
				CreateEntity.Empty()
					.AddWeaponChangeRequest(WeaponTypeId.Machinegun)
					.With(x => x.isReadyToChangeWeapon = true)
					;
			}
			else if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha3))
			{
				CreateEntity.Empty()
					.AddWeaponChangeRequest(WeaponTypeId.Sniper)
					.With(x => x.isReadyToChangeWeapon = true)
					;
			}
		}
	}
}