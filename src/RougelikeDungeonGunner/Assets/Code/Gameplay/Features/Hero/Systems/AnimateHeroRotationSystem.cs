using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class AnimateHeroRotationSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _heroes;

		public AnimateHeroRotationSystem(GameContext game)
		{
			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.HeroAnimator));
		}

		public void Execute()
		{
			//if (angleDegree >= 22f && angleDegree <= 67f)
			//	aimDirection = AimDirection.UpRight;
			//else if (angleDegree > 67f && angleDegree <= 112f)
			//	aimDirection = AimDirection.Up;
			//else if (angleDegree > 112f && angleDegree <= 158f)
			//	aimDirection = AimDirection.UpLeft;
			//else if ((angleDegree <= 180f && angleDegree > 158f) ||
			//         (angleDegree > -180f && angleDegree <= -135f))
			//	aimDirection = AimDirection.Left;
			//else if (angleDegree > -135f && angleDegree <= -45)
			//	aimDirection = AimDirection.Down;
			//else if ((angleDegree > -45f && angleDegree <= 0f) || (angleDegree > 0f && angleDegree < 22f))
			//	aimDirection = AimDirection.Right;
			//else
			//	aimDirection = AimDirection.Right;
		}
	}
}