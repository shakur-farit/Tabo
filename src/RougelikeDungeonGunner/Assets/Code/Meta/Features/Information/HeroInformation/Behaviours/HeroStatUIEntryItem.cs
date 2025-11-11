using Code.Common.Extensions;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.Features.Weapon.Services;
using Code.Meta.Features.Information.WeaponInformation.Behaviours;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using TMPro;
using UnityEngine;

namespace Code.Meta.Features.Information.HeroInformation.Behaviours
{
	public class HeroStatUIEntryItem : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private TextMeshProUGUI _value;

		public void Initialize(HeroStatUIEntryTypeId id, string value)
		{
			_name.text = id.ToDisplayName();
			_value.text = value;
		}
	}
}