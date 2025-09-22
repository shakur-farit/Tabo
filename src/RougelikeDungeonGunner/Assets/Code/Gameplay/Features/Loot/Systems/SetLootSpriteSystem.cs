using System.Collections.Generic;
using Assets.Code.Gameplay.StaticData;
using Entitas;

namespace Assets.Code.Gameplay.Features.Loot.Systems
{
	public class SetLootSpriteSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetLootSpriteSystem(GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.LootTypeId,
					GameMatcher.SpriteRenderer)
				.Added());
		}

		protected override bool Filter(GameEntity loots) =>
			loots.hasLootTypeId && loots.hasSpriteRenderer;

		protected override void Execute(List<GameEntity> loots)
		{
			foreach (GameEntity loot in loots)
				loot.SpriteRenderer.sprite =
					_staticDataService
						.GetLootConfig(loot.LootTypeId).Sprite;
		}
	}
}