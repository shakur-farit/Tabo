using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponEffectsProvider : IWeaponEffectsProvider
	{
		private readonly IWeaponUpgradesProvider _provider;

		public WeaponEffectsProvider(IWeaponUpgradesProvider provider) => 
			_provider = provider;

		public List<EffectSetup> GetEffects(WeaponConfig config)
		{
			List<EffectSetup> modifiedEffects = new(config.EffectSetups.Count);

			foreach (EffectSetup effect in config.EffectSetups)
			{
				EffectSetup newEffect = new EffectSetup
				{
					EffectTypeId = effect.EffectTypeId,
					Value = effect.Value
				};

				if (effect.EffectTypeId == EffectTypeId.Damage)
					newEffect.Value += _provider.GetUpgradeBonus(WeaponUpgradeTypeId.Damage);

				modifiedEffects.Add(newEffect);
			}

			return modifiedEffects;
		}
	}
}