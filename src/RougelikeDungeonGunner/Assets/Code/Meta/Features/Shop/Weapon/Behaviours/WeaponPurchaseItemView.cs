using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponPurchaseItemView : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _price;

		public void Initialize(Sprite sprite, int price)
		{
			_icon.sprite = sprite;
			_price.text = price.ToString();
		}
	}
}