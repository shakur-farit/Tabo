using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class SetCollisionInFrontFromWeaponSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _heroes;
		private readonly IGroup<GameEntity> _weapons;

		public SetCollisionInFrontFromWeaponSystem(GameContext game)
		{
			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.CollisionInFront));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity weapon in _weapons)
			{
				hero.isCollisionInFront = weapon.isCollisionInFront;
			}
		}
	}
}