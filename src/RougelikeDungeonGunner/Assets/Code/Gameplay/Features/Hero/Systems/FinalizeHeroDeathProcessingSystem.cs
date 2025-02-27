using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class FinalizeHeroDeathProcessingSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _heroes;

		public FinalizeHeroDeathProcessingSystem(GameContext game)
		{
			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.Dead,
					GameMatcher.ProcessingDeath));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			{
				hero.isProcessingDeath = false;
			}
		}
	}
}