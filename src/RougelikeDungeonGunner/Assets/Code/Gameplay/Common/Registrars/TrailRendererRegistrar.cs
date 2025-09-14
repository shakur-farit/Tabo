using Code.Gameplay.Features.Ammo.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Ammo.Registrars
{
	public class TrailRendererRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private TrailRenderer _trailRenderer;

		public override void RegisterComponents() => 
			Entity.AddTrailRenderer(_trailRenderer);

		public override void UnregisterComponents()
		{
			if (Entity.hasTrailRenderer)
				Entity.RemoveTrailRenderer();
		}
	}
}