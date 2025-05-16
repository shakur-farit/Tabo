using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponShopItem : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _price;
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private Button BuyItemButton;

		public void Setup(Sprite sprite, int price, string itemName)
		{
			_icon.sprite = sprite;
			_price.text = price.ToString();
			_name.text = itemName;
		}
	}
}