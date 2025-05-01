using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Meta.UI.Hud.WeaponHolder.Registrar
{
	public class WeaponHolderRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Behaviours.WeaponHolder _weaponHolder;

		public override void RegisterComponents() => 
			Entity.AddWeaponHolder(_weaponHolder);

		public override void UnregisterComponents()
		{
			if (Entity.hasWeaponHolder)
				Entity.RemoveWeaponHolder();
		}
	}
}