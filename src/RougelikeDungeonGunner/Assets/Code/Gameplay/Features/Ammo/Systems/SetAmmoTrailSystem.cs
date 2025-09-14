using System.Collections.Generic;
using Code.Gameplay.Features.Ammo.Configs;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class SetAmmoTrailSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetAmmoTrailSystem(GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Ammo,
					GameMatcher.AmmoTypeId,
					GameMatcher.TrailRenderer)
				.Added());
		}

		protected override bool Filter(GameEntity ammos) => 
			ammos.isAmmo && ammos.hasAmmoTypeId && ammos.hasTrailRenderer;

		protected override void Execute(List<GameEntity> ammos)
		{
			foreach (GameEntity ammo in ammos)
			{
				AmmoConfig config = _staticDataService.GetAmmoConfig(ammo.AmmoTypeId);
				TrailSetup trailSetup = config.TrailSetup;

				ammo.TrailRenderer.material = trailSetup.Material;
				ammo.TrailRenderer.time = trailSetup.Time;
				ammo.TrailRenderer.startWidth = trailSetup.StartWidth;
				ammo.TrailRenderer.endWidth = trailSetup.EndWidth;

			}

		}
	}
}