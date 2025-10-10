using Code.Gameplay.Features.Weapon;
using UnityEngine;

namespace Code.Meta.Features.Shop.Services
{
	public interface IWeaponShopService
	{
		Sprite WeaponSprite { get; }
		int WeaponPrice { get; }
		WeaponTypeId WeaponTypeId { get; }
		void SetWeaponSprite(Sprite sprite);
		void SetWeaponPrice(int price);
		void SetWeaponTypeId(WeaponTypeId weaponToBuy);
		void ResetWeaponSetup();
	}
}