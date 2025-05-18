using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Data;
using Code.Progress.Provider;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class WeaponBuyDialogWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Button _buyButton;
		[SerializeField] private WeaponToBuyShopItem _weaponToBuyShopItem;

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;

		public TransientData Data => _progressProvider.TransientData;
		public ShopData ShopData => Data.ShopData;

		[Inject]
		public void Constructor(IWindowService windowService, IProgressProvider progressProvider)
		{
			Id = WindowId.WeaponBuyDialogWindow;

			_windowService = windowService;
			_progressProvider = progressProvider;
		}

		protected override void Initialize()
		{
			_buyButton.onClick.AddListener(BuyWeapon);
			_closeButton.onClick.AddListener(Close);

			_weaponToBuyShopItem.Setup(ShopData.WeaponToBuyConfig);
		}

		private void BuyWeapon()
		{
			Data.HeroData.CurrentWeaponTypeId = ShopData.WeaponToBuyConfig.WeaponTypeId;
			ShopData.WeaponToBuyConfig = null;

			Close();
		}

		private void Close() =>
			_windowService.Close(WindowId.WeaponBuyDialogWindow);
	}
}