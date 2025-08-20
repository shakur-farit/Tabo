using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Effects.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Statuses.Systems
{
	public class DamageOnAreaStatusSystem : IExecuteSystem
	{
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
					GameMatcher.TargetsBuffer));
		}

		public void Execute()
		{
			foreach (GameEntity status in _statuses)
			{
				foreach (int target in status.TargetsBuffer)
				{
					_effectFactory.CreateEffect(
						GetEffectSetup(status),
						status.ProducerId,
						target);
				}
			}
		}

		private EffectSetup GetEffectSetup(GameEntity status) =>
			EffectSetup.FormId(EffectTypeId.Damage, status.EffectValue);
	}
}