using Assets.Code.Meta.Features.Shop.Upgrade.Configs;

namespace Assets.Code.Meta.Features.Shop.Upgrade.Services
{
	public interface IWeaponUpgradeValidator
	{
		bool CanUpgrade(WeaponUpgradeShopItemConfig config);
	}
}