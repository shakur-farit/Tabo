using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.UI.Windows.Service;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class EnchantBuyFacade : IEnchantBuyFacade
  {
    private readonly IWindowService _windowService;
    private readonly IDialogueService _dialogueService;
    private readonly IEnchantBuyer _buyer;
    private readonly IEnchantStatsUIRenderer _renderer;

    public EnchantBuyFacade(
      IWindowService windowService,
      IDialogueService dialogueService,
      IEnchantBuyer buyer,
      IEnchantStatsUIRenderer renderer)
    {

      _windowService = windowService;
      _dialogueService = dialogueService;
      _buyer = buyer;
      _renderer = renderer;
    }

    public void BuyEnchant()
    {
      if (_buyer.TryBuyEnchant())
        CloseWindow();
      else
        OpenNotEnoughCoinsWindow();
    }


    public void RenderStats(EnchantStatsUIHolder holder) =>
      _renderer.RenderUIStats(holder);

    public void CloseWindow() =>
      _windowService.Close(WindowId.EnchantBuyWindow);

    private void OpenNotEnoughCoinsWindow()
    {
      _dialogueService.SetDialogueText(Dialogues.NotEnoughCoins);
      _windowService.Open(WindowId.DialogueWindow);
    }
  }
}