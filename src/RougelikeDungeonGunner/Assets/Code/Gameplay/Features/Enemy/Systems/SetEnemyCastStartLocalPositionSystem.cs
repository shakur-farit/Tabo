using System.Collections.Generic;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class SetEnemyCastStartLocalPositionSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetEnemyCastStartLocalPositionSystem(GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Enemy,
					GameMatcher.EnemyTypeId,
					GameMatcher.CastStartPositionTransform)
				.Added());
		}

		protected override bool Filter(GameEntity enemies) =>
			enemies.isEnemy && enemies.hasEnemyTypeId && enemies.hasCastStartPositionTransform;

		protected override void Execute(List<GameEntity> enemies)
		{
			foreach (GameEntity enemy in enemies)
				enemy.CastStartPositionTransform.localPosition =
					_staticDataService
						.GetEnemyConfig(enemy.EnemyTypeId).CastSetup.CastStartPosiotion;

		}
	}

	public class ShowTargetSpriteSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _enemies;

		public ShowTargetSpriteSystem(GameContext game)
		{
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies)
			{
				
			}
		}
	}
}