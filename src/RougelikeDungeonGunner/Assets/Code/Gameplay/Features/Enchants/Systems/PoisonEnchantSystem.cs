using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Effects
{
	public class PoisonEnchantSystem : IExecuteSystem
	{
		private readonly IStaticDataService _staticDataService;
		private readonly IGroup<GameEntity> _enchants;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public PoisonEnchantSystem(GameContext game, IStaticDataService staticDataService)
		{
			_staticDataService = staticDataService;
			_enchants = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnchantTypeId,
					GameMatcher.ProducerId,
					GameMatcher.PoisonEnchant));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.ProducerId)
					.NoneOf(GameMatcher.PoisonEnchant));
		}

		public void Execute()
		{
			foreach (GameEntity enchant in _enchants)
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				if (enchant.ProducerId == weapon.ProducerId)
				{
					GetOrAddStatusSetups(weapon)
						.AddRange(_staticDataService.GetEnchantConfig(EnchantTypeId.PoisonEnchant).StatusSetups);
					weapon.isPoisonEnchant = true;
				}
			}
		}

		private List<StatusSetup> GetOrAddStatusSetups(GameEntity weapon)
		{
			if (weapon.hasStatusSetups == false)
				weapon.AddStatusSetups(new List<StatusSetup>());

			return weapon.StatusSetups;
		}
	}
}