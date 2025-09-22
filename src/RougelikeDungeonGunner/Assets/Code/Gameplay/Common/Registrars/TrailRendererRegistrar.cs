using Assets.Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Assets.Code.Gameplay.Common.Registrars
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