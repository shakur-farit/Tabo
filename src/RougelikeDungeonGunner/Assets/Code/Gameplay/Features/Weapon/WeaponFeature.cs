using Code.Gameplay.Features.Weapon.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.Weapon
{
	public sealed class WeaponFeature : Feature
	{
		public WeaponFeature(ISystemsFactory systems)
		{
			Add(systems.Create<UpdateWeaponSpriteSystem>());
			Add(systems.Create<UpdateFirePositionSystem>());
		}
	}
}