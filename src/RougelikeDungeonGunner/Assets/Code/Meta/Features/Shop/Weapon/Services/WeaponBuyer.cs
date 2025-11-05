using Code.Gameplay.Features.Coin.Services;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon.Services;
using Code.Meta.Features.Shop.Services;
using Code.Meta.Features.Shop.WeaponUpgrade.Services;

namespace Code.Meta.Features.Shop.Weapon.Services
{
  public class WeaponBuyer : IWeaponBuyer
  {
    private readonly IWeaponUpgradesCleaner _upgradeCleaner;
    private readonly ICoinService _coinService;
    private readonly IWeaponShopService _shopService;
    private readonly ICurrentHeroWeaponProvider _heroWeapon;
    private readonly IAmmoCountProvider _ammoCountProvider;

    public WeaponBuyer(
      IWeaponUpgradesCleaner upgraderCleaner,
      ICurrentHeroWeaponProvider heroWeapon,
      ICoinService coinService,
      IAmmoCountProvider ammoCountProvider,
      IWeaponShopService shopService)
    {
      _upgradeCleaner = upgraderCleaner;
      _coinService = coinService;
      _shopService = shopService;
      _ammoCountProvider = ammoCountProvider;
      _heroWeapon = heroWeapon;
    }

    public bool TryBuyWeapon()
    {
      if (IsNotEnoughCoins())
        return false;

      SubtractPrice();
      CleanUpgrades();
      CleanAmmoCount();
      ChangeCurrentWeapon();

      return true;
    }

    private void SubtractPrice()
    {
      int coinCount = _coinService.GetCurrentCoinCount();

      coinCount -= _shopService.WeaponPrice;

      _coinService.SetCurrentCoinCount(coinCount);
    }

    private void ChangeCurrentWeapon()
    {
      _heroWeapon.SetCurrentHeroWeapon(_shopService.WeaponTypeId);

      _shopService.ResetWeaponSetup();
    }

    private void CleanUpgrades() =>
      _upgradeCleaner.CleanUpgrades();

    private void CleanAmmoCount() =>
      _ammoCountProvider.Clean();

    private bool IsNotEnoughCoins() =>
      _coinService.GetCurrentCoinCount() < _shopService.WeaponPrice;
  }
}