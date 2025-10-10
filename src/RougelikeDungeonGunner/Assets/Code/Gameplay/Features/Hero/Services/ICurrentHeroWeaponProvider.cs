using System;
using Code.Gameplay.Features.Weapon;

namespace Code.Gameplay.Features.Hero
{
	public interface ICurrentHeroWeaponProvider
	{
		event Action WeaponChanged;
		WeaponTypeId CurrentWeaponTypeId { get; }
		void SetCurrentHeroWeapon(WeaponTypeId typeId);
	}
}