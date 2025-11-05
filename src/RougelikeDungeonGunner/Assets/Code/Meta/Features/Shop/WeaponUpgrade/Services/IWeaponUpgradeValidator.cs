using Code.Meta.Features.Shop.WeaponUpgrade.Configs;

namespace Code.Meta.Features.Shop.WeaponUpgrade.Services
{
	public interface IWeaponUpgradeValidator
	{
		bool CanUpgrade(WeaponUpgradeShopItemConfig config);
	}
}