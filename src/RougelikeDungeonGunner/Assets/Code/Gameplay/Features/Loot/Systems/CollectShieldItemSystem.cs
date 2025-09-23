using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectShieldItemSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _heroes;
		private readonly List<GameEntity> _buffer = new(1);

		public CollectShieldItemSystem(GameContext game)
		{
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.Shield));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero)
				.NoneOf(GameMatcher.ShieldApplied));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes.GetEntities(_buffer))
			foreach (GameEntity collected in _collected)
				hero.isRequestShield = collected.isShield;
		}
	}
}