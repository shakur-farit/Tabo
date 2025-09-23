using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Effects.Factory;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
	public class DamageOnAreaStatusSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(32);

		private readonly IEffectFactory _effectFactory;
		private readonly IGroup<GameEntity> _statuses;

		public DamageOnAreaStatusSystem(GameContext game, IEffectFactory effectFactory)
		{
			_effectFactory = effectFactory;
			_statuses = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Status,
					GameMatcher.Explosive,
					GameMatcher.EffectValue,
					GameMatcher.ProducerId,
					GameMatcher.Radius,
					GameMatcher.Reached,
					GameMatcher.TargetsBuffer));
		}

		public void Execute()
		{
			foreach (GameEntity status in _statuses.GetEntities(_buffer))
			{
				foreach (int target in status.TargetsBuffer)
				{
					_effectFactory.CreateEffect(
						GetEffectSetup(status),
						status.ProducerId,
						target);
				}

				status.isUnapplied = true;
			}
		}

		private EffectSetup GetEffectSetup(GameEntity status) =>
			EffectSetup.FormId(EffectTypeId.Damage, status.EffectValue);
	}
}