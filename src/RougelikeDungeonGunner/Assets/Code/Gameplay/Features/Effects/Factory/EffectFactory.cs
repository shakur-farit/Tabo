using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.Effects.Factory
{
	public class EffectFactory : IEffectFactory
	{
		private readonly IIdentifierService _identifier;

		public EffectFactory(IIdentifierService identifier) => 
			_identifier = identifier;

		public GameEntity CreateEffect(EffectSetup setup, int producerId, int targetId)
		{
			switch (setup.EffectTypeId)
			{
				case EffectTypeId.Damage:
					return	CreateDamage(producerId, targetId, setup.Value);
			}

			throw new Exception($"Effect with type id {setup.EffectTypeId} does not exist");
		}

		private GameEntity CreateDamage(int producerId, int targetId, float value)
		{
			return CreateEntity.Empty()
				.AddId(_identifier.Next())
				.With(x => x.isEffect = true)
				.With(x => x.isDamageEffect = true)
				.AddProducerId(producerId)
				.AddTargetId(targetId)
				.AddEffectValue(value)
				;
		}
	}
}