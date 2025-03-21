namespace Code.Gameplay.Features.Weapon.Factory
{
	public interface IWeaponChangeRequestFactory
	{
		GameEntity CreateWeaponChangeRequest(WeaponTypeId typeId);
	}
}