using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
	public class UnapplyPoisonVisualsSystem : ReactiveSystem<GameEntity>
	{
		public UnapplyPoisonVisualsSystem(GameContext context) : base(context)
		{
		}

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher
				.AllOf(
					GameMatcher.Posion,
					GameMatcher.Status,
					GameMatcher.Unapplied)
				.Added());

		protected override bool Filter(GameEntity entity) => entity.isStatus && entity.isPosion && entity.hasTargetId;

		protected override void Execute(List<GameEntity> statuses)
		{
			foreach (var status in statuses)
			{
				GameEntity target = status.Target();

				if (target is { hasStatusVisuals: true })
					target.StatusVisuals.UnapplyPoison();
			}
		}
	}
}