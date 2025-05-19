using System.Collections.Generic;
using Code.Gameplay.Features.Weapon.Factory;
using Code.Gameplay.StaticData;
using Code.Progress.Provider;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class HeroWeaponiseSystem : IExecuteSystem
	{
		private readonly IWeaponFactory _weaponFactory;
		private readonly IGroup<GameEntity> _heroes;
		private readonly List<GameEntity> _buffer = new(32);

		public HeroWeaponiseSystem(GameContext game, IWeaponFactory weaponFactory)
		{
			_weaponFactory = weaponFactory;

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.ParentTransform,
					GameMatcher.Unweaponed));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes.GetEntities(_buffer))
			{
				_weaponFactory.CreateWeapon(hero.CurrentWeaponTypeId, 1, hero.ParentTransform, Vector2.zero, hero.Id);

				hero.isUnweaponed = false;
			}
		}
	}
}