using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class UpdateEnemyHpViewSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _enemies;

		public UpdateEnemyHpViewSystem(GameContext game)
		{
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.EnemyHpBar,
					GameMatcher.CurrentHp,
					GameMatcher.MaxHp));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies) 
				enemy.EnemyHpBar.UpdateHpView(enemy.CurrentHp, enemy.MaxHp);
		}
	}
}