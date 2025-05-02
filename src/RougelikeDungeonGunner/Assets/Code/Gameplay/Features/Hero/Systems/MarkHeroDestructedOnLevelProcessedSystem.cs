using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class MarkHeroDestructedOnLevelProcessedSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _heroes;

		public MarkHeroDestructedOnLevelProcessedSystem(GameContext context) : base(context)
		{
			_heroes = context.GetGroup(GameMatcher.Hero);
		}

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.Processed.Added());

		protected override bool Filter(GameEntity entity) => entity.isLevel && entity.isProcessed;

		protected override void Execute(List<GameEntity> levels)
		{
			foreach (GameEntity hero in _heroes)
				hero.isDestructed = true;
		}
	}
}