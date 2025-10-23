using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Services;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class WeaponBuyWindow : BaseWindow
  {
    [SerializeField] private Button _closeButton;
    [SerializeField] private Button _buyButton;
    [SerializeField] private WeaponToBuyItem weaponToBuyItem;
    [SerializeField] private WeaponStatsUIHolder _statsUIHolder;

    private IWindowService _windowService;
    private IStaticDataService _staticDataService;
    private IWeaponShopService _shopService;
    private IWeaponBuyer _weaponBuyer;
    private IDialogueService _dialogueService;


    [Inject]
    public void Constructor(
      IWindowService windowService,
      IStaticDataService staticDataService,
      IDialogueService dialogueService,
      IWeaponShopService shopService,
      IWeaponBuyer weaponBuyer)
    {
      Id = WindowId.WeaponBuyWindow;

      _windowService = windowService;
      _staticDataService = staticDataService;
      _shopService = shopService;
      _weaponBuyer = weaponBuyer;
      _dialogueService = dialogueService;
    }

    protected override void Initialize()
    {
      _buyButton.onClick.AddListener(BuyWeapon);
      _closeButton.onClick.AddListener(CloseWindow);

      weaponToBuyItem.Setup(_shopService.WeaponSprite, _shopService.WeaponPrice);

      UpdateStatsEntry();
    }

    private void BuyWeapon()
    {
      if (_weaponBuyer.TryBuyWeapon())
        CloseWindow();
      else
        OpenNotEnoughCoinsWindow();
    }

    private void CloseWindow() =>
      _windowService.Close(WindowId.WeaponBuyWindow);

    private void UpdateStatsEntry()
    {
      WeaponConfig weaponConfig =
        _staticDataService
          .GetWeaponConfig(_shopService.WeaponTypeId);

      foreach (WeaponStatUIEntry uiEntry in weaponConfig.StatsUIEntry)
        _statsUIHolder.CreateStatUIEntryItem(uiEntry.StatUIEntryType, weaponConfig);
    }

    private void OpenNotEnoughCoinsWindow()
    {
      _dialogueService.SetDialogueText(Dialogues.NotEnoughCoins);
      _windowService.Open(WindowId.DialogueWindow);
    }
  }
}