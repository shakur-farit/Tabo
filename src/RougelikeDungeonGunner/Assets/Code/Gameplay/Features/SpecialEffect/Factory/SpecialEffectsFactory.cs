using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.SpecialEffect.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.SpecialEffect.Factory
{
	public class SpecialEffectsFactory : ISpecialEffectsFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public SpecialEffectsFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreateSpecialEffect(SpecialEffectTypeId typeId, Vector3 at)
		{
			switch (typeId)
			{
				case SpecialEffectTypeId.Smoke:
					return CreateSmoke(typeId, at);
			}

			throw new Exception($"Special effect for {typeId} type was not found");
		}

		private GameEntity CreateSmoke(SpecialEffectTypeId typeId, Vector3 at)
		{
			return CreateSpecialEffectEntity(typeId, at);
		}

		private GameEntity CreateSpecialEffectEntity(SpecialEffectTypeId typeId, Vector3 at)
		{
			SpecialEffectConfig config = _staticDataService.GetSpecialEffectConfig(typeId);

			return CreateEntity.Empty()
				.AddId(_identifier.Next())
				.AddSpecialEffectTypeId(typeId)
				.AddWorldPosition(at)
				.AddViewPrefab(config.ViewPrefab)
				.With(x => x.isSpecialEffect = true)
				;
		}
	}
}