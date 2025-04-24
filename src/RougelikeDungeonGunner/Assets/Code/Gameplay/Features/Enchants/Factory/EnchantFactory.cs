using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Enchants.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;

namespace Code.Gameplay.Features.Enchants.Factory
{
	public class EnchantFactory : IEnchantFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public EnchantFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreateEnchant(StatusSetup setup, int producerId)
		{
			switch (setup.StatusTypeId)
			{
				case StatusTypeId.Poison:
					return CreatePoisonEnchant(setup, producerId);
				case StatusTypeId.Freeze:
					return CreateFreezeEnchant(setup, producerId);
			}

			throw new Exception($"Enchant for {setup.StatusTypeId} type was not found");
		}

		private GameEntity CreatePoisonEnchant(StatusSetup setup, int producerId) =>
			CreateEnchantEntity(setup, EnchantTypeId.PoisonEnchant, producerId)
				.With(x => x.isPoisonEnchant = true);

		private GameEntity CreateFreezeEnchant(StatusSetup setup, int producerId) =>
			CreateEnchantEntity(setup, EnchantTypeId.FreezeEnchant, producerId)
				.With(x => x.isFreezeEnchant = true);

		private GameEntity CreateEnchantEntity(StatusSetup setup, EnchantTypeId typeId, int producerId)
		{
			EnchantConfig config = _staticDataService.GetEnchantConfig(typeId);

			return CreateEntity.Empty()
				.AddId(_identifier.Next())
				.AddEnchantTypeId(typeId)
				.AddStatusSetups(new List<StatusSetup> { setup })
				.AddProducerId(producerId)
				.With(x => x.isEnchant = true)
				.With(x => x.isNewCollectedEnchant = true)
				.With(x => x.AddEnchantDuration(config.Duration), when: config.Duration > 0)
				.With(x => x.AddEnchantTimeLeft(config.Duration), when: config.Duration > 0)
				;
		}
	}
}