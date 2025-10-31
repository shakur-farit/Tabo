using Code.Meta.Features.Shop.Services;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class WeaponPurchaseItemInitializer : MonoBehaviour
	{
		[SerializeField] private WeaponPurchaseItemView _weaponPurchaseItemView;

		private IWeaponShopService _shopService;
	  
		[Inject]
		public void Construct(IWeaponShopService shopService) => 
			_shopService = shopService;

		private void Start() => 
			_weaponPurchaseItemView.Initialize(GetWeaponSprite(), GetWeaponPrice());

		private Sprite GetWeaponSprite() =>
			_shopService.WeaponSprite;

		private int GetWeaponPrice() =>
			_shopService.WeaponPrice;

	}
}