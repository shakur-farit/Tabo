using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class AnimateHeroMovementSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _heroes;

		public AnimateHeroMovementSystem(GameContext game)
		{
			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.HeroAnimator));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			{
				if (hero.isMoving)
				{
					hero.HeroAnimator.StopIdling();
					hero.HeroAnimator.StartMoving();
					hero.HeroAnimator.StartAimDown();
				}
				else
				{
					hero.HeroAnimator.StopMoving();
					hero.HeroAnimator.StartIdling();
				}
			}
		}
	}
}