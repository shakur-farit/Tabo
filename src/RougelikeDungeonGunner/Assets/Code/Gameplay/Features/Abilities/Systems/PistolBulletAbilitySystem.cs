using System.Collections.Generic;
using System.Linq;
using Code.Common.Extensions;
using Code.Gameplay.Features.Armaments;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.StaticData;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Abilities.Systems
{
	public class PistolBulletAbilitySystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IStaticDataService _staticDataService;
		private readonly IArmamentFactory _armamentFactory;
		private readonly IGroup<GameEntity> _abilities;
		private readonly IGroup<GameEntity> _enemies;
		private readonly IGroup<GameEntity> _firePositions;

		public PistolBulletAbilitySystem(
			GameContext game,
			IStaticDataService staticDataService,
			IArmamentFactory armamentFactory)
		{
			_staticDataService = staticDataService;
			_armamentFactory = armamentFactory;

			_abilities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.PistolBullet,
					GameMatcher.CooldownUp));

			_firePositions = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.FirePositionTransform));

			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity ability in _abilities.GetEntities(_buffer))
			foreach (GameEntity firePosition in _firePositions)
			{
				if (_enemies.count <= 0)
					continue;

				var localPosition = firePosition.FirePositionTransform.localPosition;

				_armamentFactory.CreatePistolBullet(1, localPosition)
					.ReplaceDirection((FirstAvailableTarget().WorldPosition - localPosition).normalized)
					.With(x => x.isMoving = true);

				ability
					.PutOnCooldown(_staticDataService.GetWeaponLevel(WeaponId.Pistol, 1)
						.Cooldown);
			}
		}

		private GameEntity FirstAvailableTarget() =>
			_enemies.AsEnumerable().First();
	}
}