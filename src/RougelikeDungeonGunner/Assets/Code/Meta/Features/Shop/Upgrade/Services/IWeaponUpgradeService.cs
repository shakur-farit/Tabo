using Code.Meta.Features.Shop.Upgrade.Configs;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public interface IWeaponUpgradeService
	{
		void Upgrade(WeaponUpgradeShopItemConfig config);
		float GetUpgradeBonus(WeaponUpgradeShopItemTypeId typeId);
		void RemoveUpgrades();
	}
}