using System.Collections.Generic;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class SetAmmoMaterialSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetAmmoMaterialSystem(GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Ammo,
					GameMatcher.AmmoTypeId,
					GameMatcher.SpriteRenderer)
				.Added());
		}

		protected override bool Filter(GameEntity ammos) =>
			ammos.isAmmo && ammos.hasAmmoTypeId && ammos.hasSpriteRenderer;

		protected override void Execute(List<GameEntity> ammos)
		{
			foreach (GameEntity ammo in ammos)
				ammo.SpriteRenderer.material =
					_staticDataService
						.GetAmmoConfig(ammo.AmmoTypeId).Material;

		}
	}
}