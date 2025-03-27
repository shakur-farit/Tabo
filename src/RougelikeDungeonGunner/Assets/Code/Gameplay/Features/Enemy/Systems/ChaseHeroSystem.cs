using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class ChaseHeroSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _chasers;
		private readonly IGroup<GameEntity> _heroes;
		private readonly List<GameEntity> _buffer = new(32);

		public ChaseHeroSystem(GameContext game)
		{
			_chasers = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));

		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity chaser in _chasers.GetEntities(_buffer))
			{
				chaser.ReplaceDirection((hero.WorldPosition - chaser.WorldPosition).normalized);
				chaser.isMoving = true;
			}
		}
	}
}