using System.Collections.Generic;
using Code.Gameplay.Features.Weapon.Factory;
using Code.Gameplay.StaticData;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class HeroWeaponiseSystem : IInitializeSystem
	{
		private readonly IWeaponFactory _weaponFactory;
		private readonly IStaticDataService _staticDataService;
		private readonly IGroup<GameEntity> _heroes;
		private readonly List<GameEntity> _buffer = new(32);

		public HeroWeaponiseSystem(
			GameContext game, 
			IWeaponFactory weaponFactory,
			IStaticDataService staticDataService)
		{
			_weaponFactory = weaponFactory;
			_staticDataService = staticDataService;

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero));
		}

		public void Initialize()
		{
			foreach (GameEntity hero in _heroes.GetEntities(_buffer))
			{
				HeroConfig config = _staticDataService.GetHeroConfig(HeroTypeId.TheGeneral);

				_weaponFactory.CreateWeapon(config.StartWeapon, 1, hero, Vector2.zero);
			}
		}
	}
}