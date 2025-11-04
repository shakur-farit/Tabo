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

		private IWeaponBuyer _buyer;
		private IDialogueService _dialogueService;
		private IWindowService _windowService;

		[Inject]
		public void Construct(
			IWeaponBuyer buyer,
			IDialogueService dialogueService,
			IWindowService windowService)
		{
			Id = WindowId.WeaponBuyWindow;

			_buyer = buyer;
			_dialogueService = dialogueService;
			_windowService = windowService;
		}

		protected override void Initialize()
		{
			_buyButton.onClick.AddListener(TryBuyWeapon);
			_closeButton.onClick.AddListener(CloseWindow);
		}


		private void TryBuyWeapon()
		{
			if (_buyer.TryBuyWeapon())
				_windowService.Close(WindowId.WeaponBuyWindow);
			else
        _dialogueService.OpenNotEnoughCoinsDialogue();
    }

		private void CloseWindow() =>
			_windowService.Close(WindowId.WeaponBuyWindow);
	}
}