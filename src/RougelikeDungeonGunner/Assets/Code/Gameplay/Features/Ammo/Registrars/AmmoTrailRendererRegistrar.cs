using Code.Gameplay.Features.Ammo.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Ammo.Registrars
{
	public class AmmoTrailRendererRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private TrailRenderer _trailRenderer;

		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(IStaticDataService staticDataService) =>
			_staticDataService = staticDataService;

		public override void RegisterComponents()
		{
			AmmoConfig config = _staticDataService.GetAmmoConfig(Entity.AmmoTypeId);
			TrailSetup trailSetup = config.TrailSetup;

			_trailRenderer.material = trailSetup.Material;
			_trailRenderer.time = trailSetup.Time;
			_trailRenderer.startWidth = trailSetup.StartWidth;
			_trailRenderer.endWidth = trailSetup.EndWidth;

			Entity.AddTrailRenderer(_trailRenderer);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasTrailRenderer)
				Entity.RemoveTrailRenderer();
		}
	}
}