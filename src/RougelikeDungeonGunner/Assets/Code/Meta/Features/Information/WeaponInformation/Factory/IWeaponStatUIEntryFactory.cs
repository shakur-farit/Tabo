using Code.Meta.Features.Information.WeaponInformation.Behaviours;
using UnityEngine;

namespace Code.Meta.Features.Information.WeaponInformation.Factory
{
	public interface IWeaponStatUIEntryFactory
	{
		WeaponStatUIEntryItem CreateStatUIEntryItem(WeaponStatUIEntryTypeId id, Transform parent,
			string valueText);
	}
}