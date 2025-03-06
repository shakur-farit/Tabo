using Code.Common.Entity;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Registrars
{
	public class WeaponFirePositionRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Transform _firePosiotionTransform;

		public override void RegisterComponents() => 
			Entity.AddFirePositionTransform(_firePosiotionTransform);

		public override void UnregisterComponents()
		{
			if (Entity.hasFirePositionTransform)
				Entity.RemoveFirePositionTransform();
		}
	}
}