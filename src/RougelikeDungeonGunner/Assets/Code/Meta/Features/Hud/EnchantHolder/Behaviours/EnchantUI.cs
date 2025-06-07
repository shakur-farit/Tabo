using Code.Gameplay.Features.Enchants;
using Code.Gameplay.Features.Enchants.Configs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.Features.Hud.EnchantHolder.Behaviours
{
	public class EnchantUI : MonoBehaviour
	{
		[SerializeField] private EnchantTypeId _id;
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _timeLeftText;

		public EnchantTypeId Id => _id;

		public void Set(EnchantConfig config)
		{
			_id = config.TypeId;
			_icon.sprite = config.Sprite;
		}

		public void UpdateTimeLeftText(float value) =>
			_timeLeftText.text = Mathf.CeilToInt(value).ToString();
	}
}