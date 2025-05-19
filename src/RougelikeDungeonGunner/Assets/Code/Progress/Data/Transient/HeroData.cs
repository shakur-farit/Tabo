using System;
using Code.Gameplay.Features.Weapon;

namespace Code.Progress.Data
{
	public class HeroData
	{
		public event Action WeaponChanged;
		public event Action CoinsChanged;

		private WeaponTypeId _currentWeaponTypeId = WeaponTypeId.Unknown;
		private int _currentCoinsCount;

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

		public int CurrentCoinsCount
		{
			get => _currentCoinsCount;
			set
			{
				if (_currentCoinsCount == value)
					return;

				_currentCoinsCount = value;
				CoinsChanged?.Invoke();
			}
		}
	}
}