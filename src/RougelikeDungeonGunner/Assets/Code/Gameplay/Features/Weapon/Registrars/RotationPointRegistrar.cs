using Assets.Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Weapon.Registrars
{
	public class RotationPointRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Transform _weaponRotationPoint;

		public override void RegisterComponents() => 
			Entity.AddRotationPointTransform(_weaponRotationPoint);

		public override void UnregisterComponents()
		{
			if (Entity.hasRotationPointTransform)
				Entity.RemoveRotationPointTransform();
		}
	}
}