using Code.Common.Extensions;
using TMPro;
using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours
{
	public class WeaponStatUIEntryItem : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private TextMeshProUGUI _value;

		public void Setup(WeaponStatUIEntryTypeId id, string value)
		{
			_name.text = id.ToDisplayName();
			_value.text = value;
		}
	}
}