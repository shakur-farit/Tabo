using Code.Meta.Features.Shop.Upgrade.Configs;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public interface IWeaponUpgradeValidator
	{
		bool CanUpgrade(WeaponUpgradeShopItemConfig config);
	}
}