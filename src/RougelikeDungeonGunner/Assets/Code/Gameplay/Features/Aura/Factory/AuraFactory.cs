using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo
{
	public class AuraFactory : IAuraFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public AuraFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreateAura(AuraTypeId typeId, Vector3 at)
		{
			switch (typeId)
			{
				case AuraTypeId.Shield:
					return CreateShield(typeId, at);
				case AuraTypeId.Healing:
					return CreateHealingAura(typeId, at);
			}

			throw new Exception($"Ammo for {typeId} type was not found");
		}

		private GameEntity CreateHealingAura(AuraTypeId typeId, Vector3 at) => 
			CreateAuraEntity(typeId, at)
				.With(x=> x.isHealingAura = true);

		private GameEntity CreateShield(AuraTypeId typeId, Vector3 at) => 
			CreateAuraEntity(typeId, at)
				.With(x => x.isShield = true);

		private GameEntity CreateAuraEntity(AuraTypeId typeId, Vector3 at)
		{
			AuraConfig config = _staticDataService.GetAuraConfig(typeId);

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWorldPosition(at)
					.AddAuraTypeId(typeId)
					.AddAuraRadius(config.Radius)
					.AddViewPrefab(config.ViewPrefab)
					.With(x => x.AddAuraDuration(config.Duration), when: config.Duration > 0)
					.With(x => x.AddAuraDurationTimeLeft(config.Duration), when: config.Duration > 0)
					.With(x => x.AddCollectTargetsInterval(config.Interval), when: config.Interval> 0)
					.With(x => x.AddCollectTargetsTimer(config.Interval), when: config.Interval> 0)
					.With(x => x.AddCurrentHp(config.Durability), when: config.Durability > 0)
					.With(x => x.AddEffectSetups(config.EffectSetups), 
						when: config.EffectSetups.IsNullOrEmpty() == false)
					.With(x => x.AddStatusSetups(config.StatusSetups), 
						when: config.StatusSetups.IsNullOrEmpty() == false)
					.With(x => x.isAura = true)
					.With(x => x.isMovementAvailable = true)
					.With(x => x.isFollowMovement = true)
					.With(x => x.isMoving = true)
				;
		}
	}
}