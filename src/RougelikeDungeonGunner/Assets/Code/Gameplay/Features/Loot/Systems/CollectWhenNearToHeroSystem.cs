using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectWhenNearToHeroSystem : IExecuteSystem
	{
		private const float CloseDistance = 0.2f;

		private readonly IGroup<GameEntity> _pullables;
		private readonly IGroup<GameEntity> _heroes;


		public CollectWhenNearToHeroSystem(GameContext game)
		{
			_pullables = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Pulling,
					GameMatcher.WorldPosition));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity pullable in _pullables)
			{
				float distance = (hero.WorldPosition - pullable.WorldPosition).magnitude;

				if (distance < CloseDistance) 
					pullable.isCollected = true;
			}
		}
	}
}