using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class MarkLootDestructedOnLevelProcessedSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _loots;

		public MarkLootDestructedOnLevelProcessedSystem(GameContext context) : base(context) => 
			_loots = context.GetGroup(GameMatcher.Pullable);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.Processed.Added());

		protected override bool Filter(GameEntity entity) => entity.isLevel && entity.isProcessed;

		protected override void Execute(List<GameEntity> levels)
		{
			foreach (GameEntity loot in _loots)
				loot.isDestructed = true;
		}
	}
}