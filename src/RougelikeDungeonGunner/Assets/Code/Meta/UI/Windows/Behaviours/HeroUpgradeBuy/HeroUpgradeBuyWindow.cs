using Code.Meta.Features.Shop.HeroUpgrade.Services;
using Code.Meta.UI.Windows.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.HeroUpgradeBuy
{
  public class HeroUpgradeBuyWindow : BaseWindow
  {
    [SerializeField] private Button _closeButton;
    [SerializeField] private Button _buyButton;

    private IWindowService _windowService;
    private IHeroUpgradeBuyer _buyer;
    private IDialogueService _dialogueService;


    [Inject]
    public void Constructor(
      IWindowService windowService, 
      IHeroUpgradeBuyer buyer,
      IDialogueService dialogueService)
    {
      Id = WindowId.HeroUpgradeBuyWindow;

      _windowService = windowService;
      _buyer = buyer;
      _dialogueService = dialogueService;
    }

    protected override void Initialize()
    {
      _closeButton.onClick.AddListener(CloseWindow);
      _buyButton.onClick.AddListener(BuyUpgrade);
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

    private void OpenNotEnoughCoinsDialogue() => 
      _dialogueService.OpenNotEnoughCoinsDialogue();

    private void OpenMaxDialogue() => 
      _dialogueService.OpenMaxValueDialogue();
  }
}