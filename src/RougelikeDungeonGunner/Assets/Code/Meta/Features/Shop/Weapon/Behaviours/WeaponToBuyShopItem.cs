using Code.Meta.Features.Shop.Weapon.Configs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponToBuyShopItem : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _price;

		public void Setup(WeaponShopItemConfig config)
		{
			_icon.sprite = config.Sprite;
			_price.text = config.Price.ToString();
		}
	}
}