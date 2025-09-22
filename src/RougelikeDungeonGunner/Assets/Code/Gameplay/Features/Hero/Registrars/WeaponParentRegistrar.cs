using Assets.Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Hero.Registrars
{
	public class WeaponParentRegistrar : EntityComponentRegistrar
	{
		[SerializeField] public Transform _weaponParent;

		public override void RegisterComponents() =>
			Entity.AddParentTransform(_weaponParent);

		public override void UnregisterComponents()
		{
			if (Entity.hasParentTransform)
				Entity.RemoveParentTransform();
		}
	}
}