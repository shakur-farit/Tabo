using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class PushBackHeroOnCollisionSystem : IExecuteSystem
	{
		private const float PushBackDistancePerFrame = 0.01f;

		private readonly IGroup<GameEntity> _heroes;

		public PushBackHeroOnCollisionSystem(GameContext game)
		{
			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.Direction,
					GameMatcher.WorldPosition,
					GameMatcher.CollisionNormal,
					GameMatcher.CollisionInFront));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			{
				Vector3 pushBack = hero.CollisionNormal * PushBackDistancePerFrame;

				hero.ReplaceWorldPosition(hero.WorldPosition + pushBack);
			}
		}
	}
}