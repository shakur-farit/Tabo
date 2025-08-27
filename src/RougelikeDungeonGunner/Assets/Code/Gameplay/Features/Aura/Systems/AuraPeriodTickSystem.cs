using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo
{
	public class AuraPeriodTickSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(16);

		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _auras;

		public AuraPeriodTickSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_auras = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Aura,
					GameMatcher.AuraPeriod,
					GameMatcher.AuraPeriodTimeLeft));
		}

		public void Execute()
		{
			foreach (GameEntity aura in _auras.GetEntities(_buffer))
			{
				if (aura.AuraPeriodTimeLeft <= 0)
				{
					aura.ReplaceAuraPeriodTimeLeft(aura.AuraPeriod);
					aura.isAuraPeriodTimeUp = true;
				}
				else
					aura.ReplaceAuraPeriodTimeLeft(aura.AuraPeriodTimeLeft - _time.DeltaTime);
			}
		}
	}
}