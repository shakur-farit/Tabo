using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.Features.Shop.Enchant.Behaviours
{
	public class EnchantToBuyItem : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _price;

		public void Setup(Sprite sprite, int price)
		{
			_icon.sprite = sprite;
			_price.text = price.ToString();
		}
	}
}