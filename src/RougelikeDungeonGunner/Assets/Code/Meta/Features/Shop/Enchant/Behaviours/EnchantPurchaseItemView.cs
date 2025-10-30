using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.Features.Shop.Enchant.Behaviours
{
	public class EnchantPurchaseItemView : MonoBehaviour
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