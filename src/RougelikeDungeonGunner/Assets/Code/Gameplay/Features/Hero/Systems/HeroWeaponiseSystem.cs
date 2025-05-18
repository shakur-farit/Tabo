using System.Collections.Generic;
using Code.Gameplay.Features.Hero.Configs;
using Code.Gameplay.Features.Weapon;
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
		private readonly IStaticDataService _staticDataService;
		private readonly IProgressProvider _progressProvider;
		private readonly IGroup<GameEntity> _heroes;
		private readonly List<GameEntity> _buffer = new(32);

		public HeroWeaponiseSystem(
			GameContext game, 
			IWeaponFactory weaponFactory,
			IStaticDataService staticDataService,
			IProgressProvider progressProvider)
		{
			_weaponFactory = weaponFactory;
			_staticDataService = staticDataService;
			_progressProvider = progressProvider;

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
				HeroConfig config = _staticDataService.GetHeroConfig(HeroTypeId.TheGeneral);

				_weaponFactory.CreateWeapon(CurrentWeapon(config.StartWeapon), 1, hero.ParentTransform, Vector2.zero, hero.Id);

				hero.isUnweaponed = false;
			}
		}

		private WeaponTypeId CurrentWeapon(WeaponTypeId typeId)
		{
			WeaponTypeId currentWeapon = _progressProvider.TransientData.HeroData.CurrentWeaponTypeId;

			if(currentWeapon == WeaponTypeId.Unknown)
			  return _progressProvider.TransientData.HeroData.CurrentWeaponTypeId = typeId;

			return currentWeapon;
		}
	}
}