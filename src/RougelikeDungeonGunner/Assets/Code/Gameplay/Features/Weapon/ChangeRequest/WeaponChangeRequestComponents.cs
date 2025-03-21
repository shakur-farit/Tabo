using Entitas;

namespace Code.Gameplay.Features.Weapon.ChangeRequest.Systems
{
	[Game] public class WeaponChangeRequest : IComponent { public WeaponTypeId Value; }
	[Game] public class NewWeapon : IComponent { }
	[Game] public class ReadyToChangeWeapon : IComponent { }
}