using Code.Gameplay.Features.Weapon.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class ChangeWeaponSystem : IExecuteSystem
	{
		private readonly GameContext _game;
		private readonly IWeaponFactory _weaponFactory;
		private readonly IGroup<GameEntity> _entities;
		private readonly IGroup<GameEntity> _heroes;

		public ChangeWeaponSystem(GameContext game, IWeaponFactory weaponFactory)
		{
			_game = game;
			_weaponFactory = weaponFactory;
			_entities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.NewWeapon));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.CurrentWeaponId));
		}

		public void Execute()
		{
			foreach (GameEntity entity in _entities)
			foreach (GameEntity hero in _heroes)
			{
				var weaponEntity = _game.GetEntityWithId(hero.CurrentWeaponId);

				weaponEntity.ParentTransform.SetParent(null);
				weaponEntity.isDestructed = true;

				_weaponFactory.CreateWeapon(entity.NewWeapon, 1, hero, Vector2.zero);
			}
		}
	}
}