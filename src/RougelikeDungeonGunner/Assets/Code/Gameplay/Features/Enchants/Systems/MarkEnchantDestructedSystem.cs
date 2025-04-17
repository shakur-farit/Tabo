using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Enchants.Systems
{
	public class MarkEnchantDestructedSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _enchants;

		public MarkEnchantDestructedSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_enchants = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnchantDuration,
					GameMatcher.EnchantTimeLeft));
		}

		public void Execute()
		{
			foreach (GameEntity enchant in _enchants)
			{
				if (enchant.EnchantTimeLeft > 0)
					enchant.ReplaceEnchantTimeLeft(enchant.EnchantTimeLeft - _time.DeltaTime);
				else
					enchant.isDestructed = true;
			}
		}
	}
}