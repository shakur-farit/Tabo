using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponEffectsProvider
	{
		private readonly IWeaponUpgradesProvider _provider;
		private readonly IStaticDataService _staticDataService;

		public WeaponEffectsProvider(IWeaponUpgradesProvider provider, IStaticDataService staticDataService)
		{
			_provider = provider;
			_staticDataService = staticDataService;
		}


		public List<EffectSetup> GetEffects(WeaponConfig config)
		{
			List<EffectSetup> effects = new List<EffectSetup>()
			{
				//config.EffectSetups.
			};

			foreach (EffectSetup setup in config.EffectSetups)
			{
				if (setup.EffectTypeId == EffectTypeId.Damage)
				{
					//setup.
				}
			}

			_provider.GetUpgradeBonus(WeaponUpgradeTypeId.Damage);

			return effects;
		}
	}
}