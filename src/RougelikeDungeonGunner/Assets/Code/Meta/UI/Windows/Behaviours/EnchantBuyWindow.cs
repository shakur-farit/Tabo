using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Configs;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class EnchantBuyWindow : BaseWindow
	{
		[SerializeField] private Transform _holder;
		[SerializeField] private Button _closeButton;

		private IWindowService _windowService;
		private IEnchantShopItemFactory _factory;

		[Inject]
		public void Constructor(IWindowService windowService, IEnchantShopItemFactory factory)
		{
			Id = WindowId.EnchantBuyWindow;

			_windowService = windowService;
			_factory = factory;
		}

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			ShowEnchants();
		}

		private void Close() =>
			_windowService.Close(WindowId.EnchantBuyWindow);

		private void ShowEnchants()
		{
			List<EnchantShopItemTypeId> enchantIds = EnumUtility.InitEnumList<EnchantShopItemTypeId>();

			foreach (EnchantShopItemTypeId id in enchantIds) 
				_factory.CreateEnchantShopItem(id, _holder);
		}
	}
}