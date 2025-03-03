using System.Collections.Generic;
using System.Linq;
using Code.Common.Extensions;
using Code.Gameplay.Features.Armaments;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Abilities.Systems
{
	public class PistolBulletAbilitySystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IStaticDataService _staticDataService;
		private readonly IArmamentFactory _armamentFactory;
		private readonly IGroup<GameEntity> _abilities;
		private readonly IGroup<GameEntity> _heroes;
		private readonly IGroup<GameEntity> _enemies;

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

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));


			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity ability in _abilities.GetEntities(_buffer))
			foreach (GameEntity hero in _heroes)
			{
				if (_enemies.count <= 0)
					continue;

				_armamentFactory.CreatePistolBullet(1, hero.WorldPosition)
					.ReplaceDirection((FirstAvailableTarget().WorldPosition - hero.WorldPosition).normalized)
					.With(x => x.isMoving = true);

				ability
					.PutOnCooldown(_staticDataService.GetAbilityLevel(AbilityId.PistolBullet, 1)
						.Cooldown);
			}
		}

		private GameEntity FirstAvailableTarget() =>
			_enemies.AsEnumerable().First();
	}
}