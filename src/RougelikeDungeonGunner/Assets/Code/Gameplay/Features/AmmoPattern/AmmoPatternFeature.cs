using Code.Gameplay.Features.AmmoPattern.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.AmmoPattern
{
	public sealed class AmmoPatternFeature : Feature
	{
		public AmmoPatternFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CreatePatternForHeroPistolSystem>());
			Add(systems.Create<CreatePatternForHeroAutomaticPistolSystem>());
			Add(systems.Create<CreatePatternForHeroLaserBlasterSystem>());
			Add(systems.Create<CreatePatternForHeroMachinegunSystem>());
			Add(systems.Create<CreatePatternForHeroPlasmaGunSystem>());
			Add(systems.Create<CreatePatternForHeroRevolverSystem>());
			Add(systems.Create<CreatePatternForHeroShotgunSystem>());
			Add(systems.Create<CreatePatternForHeroRocketLauncherSystem>());
			Add(systems.Create<CreatePatternForHeroSniperSystem>());
			Add(systems.Create<CreatePatternForEnemyPistolSystem>());
		}
	}
}