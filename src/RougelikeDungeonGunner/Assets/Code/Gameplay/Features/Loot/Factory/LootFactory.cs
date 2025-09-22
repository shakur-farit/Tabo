using Assets.Code.Gameplay.Features.Loot.Configs;
using Assets.Code.Gameplay.StaticData;
using Assets.Code.Infrastructure.Identifiers;
using Code.Common.Entity;
using Code.Common.Extensions;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Loot.Factory
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
			LootConfig config = _staticDataService.GetLootConfig(typeId);

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWorldPosition(at)
					.AddLootTypeId(typeId)
					.AddViewPrefab(config.ViewPrefab)
					.With(x => x.AddCoins(config.CoinValue), when: config.CoinValue > 0)
					.With(x => x.AddEffectSetups(config.EffectSetups), when: config.EffectSetups.IsNullOrEmpty() == false)
					.With(x => x.AddStatusSetups(config.StatusSetups), when: config.StatusSetups.IsNullOrEmpty() == false)
					.With(x => x.isShield = true, when: typeId == LootTypeId.ShieldItem)
					.With(x => x.isPullable = true)
				;
		}
	}
}
