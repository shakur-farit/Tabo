using Assets.Code.Infrastructure.View.Registrars;
using Assets.Code.Meta.Features.Hud.WeaponHolder.Behaviours;
using UnityEngine;

namespace Assets.Code.Meta.Features.Hud.WeaponHolder.Registrar
{
	public class WeaponHolderRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private WeaponHolderBehaviour _weaponHolder;

		public override void RegisterComponents() => 
			Entity.AddWeaponHolder(_weaponHolder);

		public override void UnregisterComponents()
		{
			if (Entity.hasWeaponHolder)
				Entity.RemoveWeaponHolder();
		}
	}
}