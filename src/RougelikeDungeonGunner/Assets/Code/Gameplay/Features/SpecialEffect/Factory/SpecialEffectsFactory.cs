using Assets.Code.Common.Extensions;
using Assets.Code.Gameplay.Features.SpecialEffect.Configs;
using Assets.Code.Gameplay.StaticData;
using Assets.Code.Infrastructure.Identifiers;
using Code.Common.Entity;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.SpecialEffect.Factory
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
			SpecialEffectConfig config = _staticDataService.GetSpecialEffectConfig(typeId);

			return CreateEntity.Empty()
				.AddId(_identifier.Next())
				.AddSpecialEffectTypeId(typeId)
				.AddWorldPosition(at)
				.AddViewPrefab(config.ViewPrefab)
        .AddSelfDestructedTimer(config.Lifetime)
				.With(x => x.isSpecialEffect = true)
				;
		}
	}
}