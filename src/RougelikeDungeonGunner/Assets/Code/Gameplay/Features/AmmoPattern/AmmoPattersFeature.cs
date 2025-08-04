using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Ammo
{
	public sealed class AmmoPattersFeature : Feature
	{
		public AmmoPattersFeature(ISystemsFactory systems)
		{
			Add(systems.Create<RotatePatternSystem>());
		}
	}
}