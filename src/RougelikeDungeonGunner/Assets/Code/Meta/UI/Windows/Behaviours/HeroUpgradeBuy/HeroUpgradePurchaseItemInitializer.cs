using Code.Meta.Features.Shop.Services;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class HeroUpgradePurchaseItemInitializer : MonoBehaviour
	{
		[SerializeField] private HeroUpgradePurchaseItemView _heroUpgradePurchaseItemView;

		private IHeroUpgradeShopService _shopService;

		[Inject]
		public void Constructor(IHeroUpgradeShopService shopService) =>
			_shopService = shopService;

		private void Start() =>
			_heroUpgradePurchaseItemView.Initialize(_shopService.HeroUpgradeSprite, _shopService.HeroUpgradePrice,
				_shopService.HeroUpgradeValue);
	}
}