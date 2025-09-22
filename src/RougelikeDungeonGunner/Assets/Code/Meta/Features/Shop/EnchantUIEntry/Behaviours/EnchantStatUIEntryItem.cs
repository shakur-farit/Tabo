using Assets.Code.Common.Extensions;
using TMPro;
using UnityEngine;

namespace Assets.Code.Meta.Features.Shop.EnchantUIEntry.Behaviours
{
	public class EnchantStatUIEntryItem : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private TextMeshProUGUI _value;

		public void Setup(EnchantStatUIEntryTypeId id, string value)
		{
			_name.text = id.ToDisplayName();
			_value.text = value;
		}
	}
}