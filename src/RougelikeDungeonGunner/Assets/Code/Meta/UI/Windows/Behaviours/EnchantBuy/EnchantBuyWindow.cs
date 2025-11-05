using Code.Meta.Features.Shop.Enchant.Services;
using Code.Meta.UI.Windows.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.EnchantBuy
{
	public class EnchantBuyWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Button _buyButton;

    private IWindowService _windowService;
    private IDialogueService _dialogueService;
    private IEnchantBuyer _buyer;

		[Inject]
		public void Constructor(
			IWindowService windowService,
			IDialogueService dialogueService,
			IEnchantBuyer buyer)
		{
			Id = WindowId.EnchantBuyWindow;

			_windowService = windowService;
			_dialogueService = dialogueService;
			_buyer = buyer;
    }

		protected override void Initialize()
		{
			_buyButton.onClick.AddListener(BuyEnchant);
			_closeButton.onClick.AddListener(CloseWindow);
		}

		private void BuyEnchant()
		{
			if (_buyer.TryBuyEnchant())
				CloseWindow();
			else
				OpenNotEnoughCoinsWindow();
		}

		private void CloseWindow() =>
			_windowService.Close(WindowId.EnchantBuyWindow);

		public void OpenNotEnoughCoinsWindow() => 
      _dialogueService.OpenNotEnoughCoinsDialogue();
  }
}