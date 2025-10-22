using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Loot.Configs;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using System;
using UnityEngine;

namespace Code.Gameplay.Features.Loot.Factory
{
	public class LootFactory : ILootFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public LootFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreateLoot(LootTypeId typeId, Vector3 at)
		{
			switch (typeId)
			{
				case LootTypeId.AmmoItem:
					return CreateAmmoLoot(typeId, at);
				case LootTypeId.MissileItem:
					return CreateMissileLoot(typeId, at);
				case LootTypeId.CoinItem:
					return CreateCoins(typeId, at);
			}

			return CreateLootEntity(typeId, at);
		}

		private GameEntity CreateCoins(LootTypeId typeId, Vector3 at) =>
			CreateLootEntity(typeId, at)
				.With(x => x.isCoins = true);

		private GameEntity CreateMissileLoot(LootTypeId typeId, Vector3 at) =>
			CreateLootEntity(typeId, at)
				.With(x => x.isMissileLoot= true);

		private GameEntity CreateAmmoLoot(LootTypeId typeId, Vector3 at) => 
			CreateLootEntity(typeId, at)
				.With(x => x.isAmmoLoot = true);

		private GameEntity CreateLootEntity(LootTypeId typeId, Vector3 at)
		{
			LootConfig config = _staticDataService.GetLootConfig(typeId);

			return CreateGameEntity.Empty()
					.AddId(_identifier.Next())
					.AddWorldPosition(at)
					.AddLootTypeId(typeId)
					.AddViewPrefab(config.ViewPrefab)
					.AddSoundEffectTypeId(config.PickupSoundEffectTypeId)
					.With(x => x.AddLootValue(config.Value), when: config.Value > 0)
					.With(x => x.AddEffectSetups(config.EffectSetups), when: config.EffectSetups.IsNullOrEmpty() == false)
					.With(x => x.AddStatusSetups(config.StatusSetups), when: config.StatusSetups.IsNullOrEmpty() == false)
					.With(x => x.isShield = true, when: typeId == LootTypeId.ShieldItem)
					.With(x => x.isPullable = true)
					.With(x => x.isReusable = true)
				;
		}
	}
}
