using Code.Meta.Features.Shop.Services;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class HeroUpgradeBuyWindow : BaseWindow
  {
    [SerializeField] private Button _closeButton;
    [SerializeField] private Button _buyButton;
    [SerializeField] private HeroUpgradeToBuyItem _heroUpgradeToBuyItem;

    private IWindowService _windowService;
    private IHeroUpgradeShopService _shopService;
    private IHeroUpgradeBuyer _buyer;
    private IDialogueService _dialogueService;


    [Inject]
    public void Constructor(
      IWindowService windowService, 
      IHeroUpgradeShopService shopService, 
      IHeroUpgradeBuyer buyer,
      IDialogueService dialogueService)
    {
      Id = WindowId.HeroUpgradeBuyWindow;

      _windowService = windowService;
      _shopService = shopService;
      _buyer = buyer;
      _dialogueService = dialogueService;
    }

    protected override void Initialize()
    {
      _closeButton.onClick.AddListener(CloseWindow);
      _buyButton.onClick.AddListener(BuyUpgrade);

      _heroUpgradeToBuyItem.Setup(_shopService.HeroUpgradeSprite, _shopService.HeroUpgradePrice,
        _shopService.HeroUpgradeValue);
    }

    private void BuyUpgrade()
    {
      if (_buyer.IsNotEnoughCoins())
      {
        OpenNotEnoughCoinsDialogue();
        return;
      }

      if (_buyer.TryBuyUpgrade() == false)
      {
        OpenMaxDialogue();
        return;
      }

      CloseWindow();
    }

    private void CloseWindow() =>
      _windowService.Close(WindowId.HeroUpgradeBuyWindow);

    private void OpenNotEnoughCoinsDialogue()
    {
      _dialogueService.SetDialogueText(Dialogues.NotEnoughCoins);
      _windowService.Open(WindowId.DialogueWindow);
    }

    private void OpenMaxDialogue()
    {
      _dialogueService.SetDialogueText(Dialogues.MaxValue);
      _windowService.Open(WindowId.DialogueWindow);
    }
  }
}