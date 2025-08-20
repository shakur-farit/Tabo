using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Enchants.Systems
{
	public class FlameEnchantSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _enchants;
		private readonly IGroup<GameEntity> _ammo;
		private readonly List<GameEntity> _buffer = new(32);
		private readonly List<GameEntity> _enchantsBuffer = new(32);

		public FlameEnchantSystem(GameContext game)
		{
			_enchants = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.StatusSetups,
					GameMatcher.ProducerId,
					GameMatcher.FlameEnchant));

			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.ProducerId)
				.NoneOf(GameMatcher.FlameEnchant));
		}

		public void Execute()
		{
			foreach (GameEntity enchant in _enchants.GetEntities(_enchantsBuffer))
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer))
			{
				if (enchant.ProducerId == ammo.ProducerId)
				{
					GetOrAddStatusSetups(ammo)
						.AddRange(enchant.StatusSetups);
					ammo.isFlameEnchant = true;
				}
			}
		}

		private List<StatusSetup> GetOrAddStatusSetups(GameEntity ammo)
		{
			if (ammo.hasStatusSetups == false)
				ammo.AddStatusSetups(new List<StatusSetup>());

			return ammo.StatusSetups;
		}
	}
}