using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Services;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.WeaponBuy
{
	public class WeaponStatsRenderer : MonoBehaviour
	{
		[SerializeField] private WeaponStatsUIHolder _weaponStatsUIHolder;

		private IStaticDataService _staticDataService;
		private IWeaponShopService _shopService;

		[Inject]
		public void Constructor(IStaticDataService staticDataService, IWeaponShopService shopService)
		{
			_staticDataService = staticDataService;
			_shopService = shopService;
		}

		private void Start() => 
			RenderUIStats();

		private void RenderUIStats()
		{
			WeaponConfig weaponConfig =
				_staticDataService
					.GetWeaponConfig(_shopService.WeaponTypeId);

			foreach (WeaponStatUIEntry uiEntry in weaponConfig.StatsUIEntry)
				_weaponStatsUIHolder.CreateStatUIEntryItem(uiEntry.StatUIEntryType, weaponConfig);
		}
	}
}