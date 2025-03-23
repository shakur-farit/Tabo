using Code.Gameplay.Features.Weapon.ChangeRequest.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.Weapon.ChangeRequest
{
	public sealed class WeaponChangeRequestFeature : Feature
	{
		public WeaponChangeRequestFeature(ISystemsFactory systems)
		{
			Add(systems.Create<ProcessedWeaponChangeRequestSystem>());

			Add(systems.Create<CleanupWeaponChangeRequestSystem>());
		}
	}
}