using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Enchant.Configs;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using Code.Meta.Features.Shop.EnchantUIEntry.Services;
using Code.Meta.Features.Shop.Services;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.EnchantBuy
{
	public class EnchantStatsRenderer : MonoBehaviour
	{
		[SerializeField] private EnchantStatsUIHolder _enchantStatsUIHolder;

		private ISelectedEnchantUIEntryProvider _enchantUIEntry;
		private IStaticDataService _staticDataService;
		private IEnchantShopService _shopService;

		[Inject]
		public void Constructor(
			ISelectedEnchantUIEntryProvider enchantUIEntry,
			IStaticDataService staticDataService,
			IEnchantShopService shopService)
		{
			_enchantUIEntry = enchantUIEntry;
			_staticDataService = staticDataService;
			_shopService = shopService;
		}

		private void Start() =>
			RenderStats();

		private void RenderStats()
		{
			EnchantShopItemConfig config =
				_staticDataService.GetEnchantShopItemConfig(_shopService.EnchantTypeId);

			_enchantUIEntry.SetStatusSetup(config.Enchnat);

			foreach (EnchantStatUIEntry statUIEntry in config.EnchantStatUIEntries)
				_enchantStatsUIHolder.CreateStats(statUIEntry.TypeId);
		}
	}
}