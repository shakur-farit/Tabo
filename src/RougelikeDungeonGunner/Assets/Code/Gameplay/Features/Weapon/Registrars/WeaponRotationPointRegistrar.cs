using Code.Common.Entity;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Registrars
{
	public class WeaponRotationPointRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Transform _weaponRotationPoint;

		public override void RegisterComponents()
		{
			CreateEntity.Empty()
				.AddWeaponRotationPointTransform(_weaponRotationPoint);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasFirePositionTransform)
				Entity.RemoveWeaponRotationPointTransform();
		}
	}
}