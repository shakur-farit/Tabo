using Code.Meta.Features.Shop.Enchant.Behaviours;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class EnchantBuyWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Button _buyButton;
		[SerializeField] private EnchantToBuyItem _enchantToBuyItem;
		[SerializeField] private EnchantStatsUIHolder _holder;

    private IEnchantBuyFacade _facade;
    private IEnchantShopService _shopService;


    [Inject]
		public void Constructor(IEnchantBuyFacade facade, IEnchantShopService shopService)
		{
			Id = WindowId.EnchantBuyWindow;

      _facade = facade;
      _shopService = shopService;
    }

		protected override void Initialize()
		{
			_buyButton.onClick.AddListener(_facade.BuyEnchant);
			_closeButton.onClick.AddListener(_facade.CloseWindow);

			_enchantToBuyItem.Setup(_shopService.EnchantSprite, _shopService.EnchantPrice);

			_facade.RenderStats(_holder);
		}
  }
}