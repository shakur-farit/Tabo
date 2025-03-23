namespace Code.Gameplay.Features.Weapon.ChangeRequest.Factory
{
	public interface IWeaponChangeRequestFactory
	{
		GameEntity CreateWeaponChangeRequest(WeaponTypeId typeId);
	}
}