using Code.Meta.Features.Shop.WeaponUpgrade.Configs;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public interface IWeaponUpgradeService
	{
		void Upgrade(WeaponUpgradeShopItemConfig config);
	}
}