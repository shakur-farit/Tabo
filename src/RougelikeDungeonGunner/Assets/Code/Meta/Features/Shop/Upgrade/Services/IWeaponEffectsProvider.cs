using System.Collections.Generic;
using Assets.Code.Gameplay.Features.Effects;
using Assets.Code.Gameplay.Features.Weapon.Configs;

namespace Assets.Code.Meta.Features.Shop.Upgrade.Services
{
	public interface IWeaponEffectsProvider
	{
		List<EffectSetup> GetEffects(WeaponConfig config);
	}
}