using System;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Weapon;

namespace Code.Progress.Data.Transient
{
	public class HeroData
	{
		public event Action WeaponChanged;
		public HeroTypeId CurrentHeroTypeId;
		
		private WeaponTypeId _currentWeaponTypeId = WeaponTypeId.Unknown;

    public WeaponTypeId CurrentWeaponTypeId
		{
			get => _currentWeaponTypeId;
			set
			{
				if (_currentWeaponTypeId == value)
					return;

				_currentWeaponTypeId = value;
				WeaponChanged?.Invoke();
			}
		}
  }
}