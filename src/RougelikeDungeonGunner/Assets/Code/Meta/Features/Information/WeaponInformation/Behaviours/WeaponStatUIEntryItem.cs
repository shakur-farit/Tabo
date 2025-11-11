using Code.Common.Extensions;
using TMPro;
using UnityEngine;

namespace Code.Meta.Features.Information.WeaponInformation.Behaviours
{
	public class WeaponStatUIEntryItem : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private TextMeshProUGUI _value;

		public void Initialize(WeaponStatUIEntryTypeId id, string value)
		{
			_name.text = id.ToDisplayName();
			_value.text = value;
		}
	}
}