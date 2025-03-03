using Code.Gameplay.Features.Abilities.Systems;
using Code.Gameplay.Features.Cooldowns.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.Abilities
{
	public sealed class AbilityFeature : Feature
	{
		public AbilityFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CooldownSystem>());
			Add(systems.Create<PistolBulletAbilitySystem>());
		}
	}
}