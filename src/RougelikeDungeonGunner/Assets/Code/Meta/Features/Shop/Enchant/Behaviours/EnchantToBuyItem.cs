using Code.Meta.Features.Shop.Enchant.Configs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.Features.Shop.Enchant.Behaviours
{
	public class EnchantToBuyItem : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _price;

		public void Setup(EnchantShopItemConfig config)
		{
			_icon.sprite = config.Sprite;
			_price.text = config.Price.ToString();
		}
	}
}