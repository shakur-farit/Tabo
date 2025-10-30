using Code.Meta.Features.Shop.Enchant.Behaviours;
using Code.Meta.Features.Shop.Services;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class EnchantPurchaseItemInitializer : MonoBehaviour
	{
		[SerializeField] private EnchantPurchaseItemView _enchantPurchaseItemView;

		private IEnchantShopService _shopService;

		[Inject]
		public void Constructor(IEnchantShopService shopService) => 
			_shopService = shopService;

		private void Start() => 
			_enchantPurchaseItemView.Initialize(_shopService.EnchantSprite, _shopService.EnchantPrice);
	}
}