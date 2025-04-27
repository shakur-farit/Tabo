using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Effects.Factory;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
	public class PeriodicDamageOnAreaStatusSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
		private readonly IEffectFactory _effectFactory;
		private readonly IGroup<GameEntity> _statuses;

		public PeriodicDamageOnAreaStatusSystem(GameContext game, ITimeService time, IEffectFactory effectFactory)
		{
			_time = time;
			_effectFactory = effectFactory;
			_statuses = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Status,
					GameMatcher.Period,
					GameMatcher.EffectValue,
					GameMatcher.TimeSinceLastTick,
					GameMatcher.ProducerId,
					GameMatcher.Radius,
					GameMatcher.TargetsBuffer));
		}

		public void Execute()
		{
			foreach (GameEntity status in _statuses)
			{
				if (status.TimeSinceLastTick >= 0)
				{
					status.ReplaceTimeSinceLastTick(status.TimeSinceLastTick - _time.DeltaTime);
				}
				else
				{
					foreach (int target in status.TargetsBuffer)
					{
						status.ReplaceTimeSinceLastTick(status.Period);
						_effectFactory.CreateEffect(
							GetEffectSetup(status),
							status.ProducerId,
							target);
					}

					status.ReplaceTimeSinceLastTick(status.Period);
				}
			}
		}

		private EffectSetup GetEffectSetup(GameEntity status) =>
			EffectSetup.FormId(EffectTypeId.Damage, status.EffectValue);
	}
}