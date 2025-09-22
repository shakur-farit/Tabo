using System.Collections.Generic;
using Assets.Code.Gameplay.StaticData;
using Entitas;

namespace Assets.Code.Gameplay.Features.Ammo.Systems
{
	public class SetAmmoSpriteSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetAmmoSpriteSystem(GameContext context, IStaticDataService staticDataService)
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
				ammo.SpriteRenderer.sprite =
					_staticDataService
						.GetAmmoConfig(ammo.AmmoTypeId).Sprite;

		}
	}
}