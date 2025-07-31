using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class PushBackHeroOnCollisionFrontWeaponSystem : IExecuteSystem
	{
		private const float PushBackDistancePerFrame = 0.03f;

		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _heroes;

		public PushBackHeroOnCollisionFrontWeaponSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.HeroWeapon,
					GameMatcher.Direction,
					GameMatcher.CollisionInFront));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity weapon in _weapons)
			{
				Vector2 pushBack = -weapon.Direction.normalized * PushBackDistancePerFrame;
				Vector3 newPosition = hero.WorldPosition + (Vector3)pushBack;
				hero.ReplaceWorldPosition(newPosition);
			}
		}
	}
}