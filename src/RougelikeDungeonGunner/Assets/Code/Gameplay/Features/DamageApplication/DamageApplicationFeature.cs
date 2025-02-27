using Code.Gameplay.Features.DamageApplication.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.DamageApplication
{
	public sealed class DamageApplicationFeature : Feature
	{
		public DamageApplicationFeature(ISystemsFactory systems)
		{
			Add(systems.Create<ApplyDamageOnTargetsSystem>());
		}
	}
}