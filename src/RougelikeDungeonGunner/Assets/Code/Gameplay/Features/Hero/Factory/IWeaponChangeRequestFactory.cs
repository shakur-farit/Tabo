using Code.Gameplay.Features.Weapon;

namespace Code.Gameplay.Features.Hero.Factory
{
	public interface IWeaponChangeRequestFactory
	{
		GameEntity CreateWeaponChangeRequest(WeaponTypeId typeId);
	}
}