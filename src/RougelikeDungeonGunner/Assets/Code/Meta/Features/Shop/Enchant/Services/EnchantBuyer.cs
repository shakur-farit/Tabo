using System.Linq;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Services;
using Code.Meta.Features.Shop.EnchantUIEntry.Services;
using Code.Meta.Features.Shop.Services;
using Code.Meta.UI.Windows.Service;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class EnchantBuyer : IEnchantBuyer
  {
    private readonly ICoinService _coinService;
    private readonly IEnchantShopService _shopService;
    private readonly ISelectedEnchantUIEntryProvider _enchantUIEntry;
    private readonly IWeaponStatusSetupProvider _weaponStatusSetupProvider;
    private readonly IDialogueService _dialogueService;
    private readonly ICurrentHeroWeaponProvider _heroWeapon;

    public EnchantBuyer(
      ICoinService coinService, 
      IEnchantShopService shopService,
      ISelectedEnchantUIEntryProvider enchantUIEntry, 
      IWeaponStatusSetupProvider weaponStatusSetupProvider,
      IDialogueService dialogueService,
      ICurrentHeroWeaponProvider heroWeapon)
    {
      _coinService = coinService;
      _shopService = shopService;
      _enchantUIEntry = enchantUIEntry;
      _weaponStatusSetupProvider = weaponStatusSetupProvider;
      _dialogueService = dialogueService;
      _heroWeapon = heroWeapon;
    }

    public bool TryBuyEnchant()
    {
      if (IsNotEnoughCoins())
        return false;

      SubtractPrice();
      AddEnchant();
      return true;
    }

    private void SubtractPrice()
    {
      int coinCount = _coinService.GetCurrentCoinCount();

      coinCount -= _shopService.EnchantPrice;

      _coinService.SetCurrentCoinCount(coinCount);
    }

    private void AddEnchant()
    {
      StatusSetup selectedEnchant = _enchantUIEntry.StatusSetup;
      WeaponTypeId currentWeapon = _heroWeapon.CurrentWeaponTypeId;

      if (_weaponStatusSetupProvider.GetStatusSetups(currentWeapon)
          .Any(e => e.StatusTypeId == selectedEnchant.StatusTypeId))
      {
        _dialogueService.OpenAppliedEnchantDialogue();
        return;
      }

      _weaponStatusSetupProvider.AddBoughtStatusSetup(currentWeapon, selectedEnchant);
    }

    private bool IsNotEnoughCoins() =>
      _coinService.GetCurrentCoinCount() < _shopService.EnchantPrice;
  }
}