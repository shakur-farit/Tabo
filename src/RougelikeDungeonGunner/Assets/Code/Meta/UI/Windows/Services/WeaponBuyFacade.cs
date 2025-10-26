using Code.Gameplay.Common;
using Code.Meta.Features.Shop.Enchant.Behaviours;
using Code.Meta.Features.Shop.Services;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.WSA;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class WeaponBuyFacade : IWeaponBuyFacade
  {
    private readonly IWeaponShopService _shopService;
    private readonly IWeaponBuyer _buyer;
    private readonly IWeaponStatsUIRenderer _renderer;
    private readonly IDialogueService _dialogueService;
    private readonly IWindowService _windowService;

    public WeaponBuyFacade(
      IWeaponShopService shopService,
      IWeaponBuyer buyer,
      IWeaponStatsUIRenderer renderer,
      IDialogueService dialogueService,
      IWindowService windowService)
    {
      _shopService = shopService;
      _buyer = buyer;
      _renderer = renderer;
      _dialogueService = dialogueService;
      _windowService = windowService;
    }

    public Sprite GetWeaponSprite() => _shopService.WeaponSprite;
    public int GetWeaponPrice() => _shopService.WeaponPrice;

    public void TryBuyWeapon()
    {
      if (_buyer.TryBuyWeapon())
        _windowService.Close(WindowId.WeaponBuyWindow);
      else
      {
        _dialogueService.SetDialogueText(Dialogues.NotEnoughCoins);
        _windowService.Open(WindowId.DialogueWindow);
      }
    }

    public void RenderWeaponStats(WeaponStatsUIHolder holder) =>
      _renderer.RenderUIStats(holder);

    public void CloseWindow() =>
      _windowService.Close(WindowId.WeaponBuyWindow);
  }
}