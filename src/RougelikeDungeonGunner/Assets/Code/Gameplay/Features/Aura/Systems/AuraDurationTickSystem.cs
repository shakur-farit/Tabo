using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Ammo
{
	public class AuraDurationTickSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(16);

		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _auras;

		public AuraDurationTickSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_auras = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Aura,
					GameMatcher.AuraDuration,
					GameMatcher.AuraDurationTimeLeft));
		}

		public void Execute()
		{
			foreach (GameEntity aura in _auras.GetEntities(_buffer))
			{
				aura.ReplaceAuraDurationTimeLeft(aura.AuraDurationTimeLeft - _time.DeltaTime);

				if (aura.AuraDurationTimeLeft <= 0)
					aura.isProcessed = true;
			}
		}
	}
}