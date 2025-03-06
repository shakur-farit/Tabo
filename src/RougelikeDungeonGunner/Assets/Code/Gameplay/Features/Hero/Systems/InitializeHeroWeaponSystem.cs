using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class InitializeHeroWeaponSystem : IInitializeSystem
	{
		private readonly IWeaponFactory _weaponFactory;
		private readonly IGroup<GameEntity> _heroes;

		public InitializeHeroWeaponSystem(GameContext game, IWeaponFactory weaponFactory)
		{
			_weaponFactory = weaponFactory;

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero));
		}

		public void Initialize()
		{
			foreach (GameEntity hero in _heroes) 
				_weaponFactory.CreateWeapon(WeaponId.Pistol, 1, hero, Vector2.zero);
		}
	}
}