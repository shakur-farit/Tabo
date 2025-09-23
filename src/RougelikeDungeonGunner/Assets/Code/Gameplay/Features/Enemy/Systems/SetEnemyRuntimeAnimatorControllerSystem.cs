using System.Collections.Generic;
using Code.Gameplay.Features.Enemy.Configs;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class SetEnemyRuntimeAnimatorControllerSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetEnemyRuntimeAnimatorControllerSystem(
			GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Enemy,
					GameMatcher.EnemyTypeId,
					GameMatcher.EnemyAnimator)
				.Added());
		}

		protected override bool Filter(GameEntity enemies) =>
			enemies.isEnemy 
			&& enemies.hasEnemyTypeId 
			&& enemies.hasEnemyAnimator;

		protected override void Execute(List<GameEntity> enemies)
		{
			foreach (GameEntity enemy in enemies)
			{
				EnemyConfig config = _staticDataService.GetEnemyConfig(enemy.EnemyTypeId);

				enemy.EnemyAnimator.SetRuntimeAnimatorController(config.AnimatorController);
			}
		}
	}
}