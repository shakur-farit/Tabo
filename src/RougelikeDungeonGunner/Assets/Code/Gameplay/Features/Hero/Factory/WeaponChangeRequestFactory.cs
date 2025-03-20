using Code.Common.Entity;
using Code.Gameplay.Features.Weapon;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.Hero.Factory
{
	public class WeaponChangeRequestFactory : IWeaponChangeRequestFactory
	{
		private readonly IIdentifierService _identifier;

		public WeaponChangeRequestFactory(IIdentifierService identifier) => 
			_identifier = identifier;

		public GameEntity CreateWeaponChangeRequest(WeaponTypeId typeId)
		{
			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddNewWeapon(typeId)
				;
		}
	}
}