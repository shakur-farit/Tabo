using Code.Common.Extensions;
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