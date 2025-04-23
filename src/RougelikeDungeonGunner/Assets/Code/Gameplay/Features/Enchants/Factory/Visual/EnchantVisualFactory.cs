using Code.Common.Entity;
using Code.Gameplay.Features.Enchants.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Enchants.Factory
{
	public class EnchantVisualFactory : IEnchantVisualFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public EnchantVisualFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreateEnchantVisual(EnchantTypeId typeId, Transform parent)
		{
			EnchantConfig config = _staticDataService.GetEnchantConfig(typeId);

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddEnchantTypeId(typeId)
					.AddViewPrefab(config.ViewPrefab)
					.AddViewParent(parent)
				;
		}
	}
}