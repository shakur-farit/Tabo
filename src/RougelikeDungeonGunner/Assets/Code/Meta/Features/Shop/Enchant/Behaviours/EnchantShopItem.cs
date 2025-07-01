using Code.Common.Extensions;
using Code.Gameplay.Features.Statuses;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry.Configs
{
	public class EnchantShopItem : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private TextMeshProUGUI _price;

		private StatusSetup _enchant;

		public void Setup(EnchantShopItemConfig config)
		{
			_icon.sprite = config.Sprite;
			_name.text = config.TypeId.ToDisplayName();
			_price.text = config.Price.ToString();
			_enchant = config.Enchnat;
		}
	}
}