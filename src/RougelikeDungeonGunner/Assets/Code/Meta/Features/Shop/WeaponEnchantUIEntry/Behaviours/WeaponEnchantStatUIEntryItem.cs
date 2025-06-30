using Code.Common.Extensions;
using TMPro;
using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponEnchantUIEntry.Behaviours
{
	public class WeaponEnchantStatUIEntryItem : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private TextMeshProUGUI _value;

		public void Setup(WeaponEnchantStatUIEntryTypeId id, string value)
		{
			_name.text = id.ToDisplayName();
			_value.text = value;
		}
	}
}