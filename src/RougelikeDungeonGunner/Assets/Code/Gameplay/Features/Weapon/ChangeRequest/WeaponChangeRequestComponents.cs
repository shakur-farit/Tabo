using Entitas;

namespace Code.Gameplay.Features.Weapon.ChangeRequest
{
	[Game] public class WeaponChangeable : IComponent { }
	[Game] public class NewWeaponTypeId : IComponent { public WeaponTypeId Value; }
	[Game] public class WeaponChangeRequested : IComponent { }
}