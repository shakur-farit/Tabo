using System;
using Code.Gameplay.Features.Weapon;

namespace Code.Gameplay.Features.Hero.Services
{
	public class CurrentHeroWeaponProvider : ICurrentHeroWeaponProvider
	{
		public event Action WeaponChanged;

		private WeaponTypeId _currentWeaponTypeId = WeaponTypeId.Unknown;

		public WeaponTypeId CurrentWeaponTypeId => _currentWeaponTypeId;

		public void SetCurrentHeroWeapon(WeaponTypeId typeId)
		{
			if (_currentWeaponTypeId == typeId)
				return;

			_currentWeaponTypeId = typeId;

			WeaponChanged?.Invoke();
		}
	}
}