using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Weapon.Configs;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public interface IWeaponEffectsProvider
	{
		List<EffectSetup> GetEffects(WeaponConfig config);
	}
}