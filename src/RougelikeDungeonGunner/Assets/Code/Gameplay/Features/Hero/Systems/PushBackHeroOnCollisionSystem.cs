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
					GameMatcher.CollisionInFront));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			{
				Vector2 dir = hero.Direction.normalized;

				Vector2 collisionNormal = 
					Mathf.Abs(dir.x) > Mathf.Abs(dir.y) ? 
						new Vector2(dir.x > 0 ? -1f : 1f, 0f) : 
						new Vector2(0f, dir.y > 0 ? -1f : 1f);

				Vector3 pushBack = (collisionNormal * PushBackDistancePerFrame);

				hero.ReplaceWorldPosition(hero.WorldPosition + pushBack);

				Debug.DrawLine(hero.WorldPosition, hero.WorldPosition + pushBack, Color.red, 0f, false);
			}
		}
	}
}