using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.ChangeRequest.Factory;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Hero.Behaviours
{
	public class WeaponChanger : MonoBehaviour
	{
		private IWeaponChangeRequestFactory _requestFactory;

		[Inject]
		public void Constructor(IWeaponChangeRequestFactory requestFactory) => 
			_requestFactory = requestFactory;

		private void Update()
		{
			if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha1))
				_requestFactory.CreateWeaponChangeRequest(WeaponTypeId.Pistol);
			else if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha2))
				_requestFactory.CreateWeaponChangeRequest(WeaponTypeId.Machinegun);
			else if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha3))
				_requestFactory.CreateWeaponChangeRequest(WeaponTypeId.Sniper);
			else if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha4))
				_requestFactory.CreateWeaponChangeRequest(WeaponTypeId.Shotgun);
			else if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha5))
				_requestFactory.CreateWeaponChangeRequest(WeaponTypeId.LaserBlaster);
		}
	}
}