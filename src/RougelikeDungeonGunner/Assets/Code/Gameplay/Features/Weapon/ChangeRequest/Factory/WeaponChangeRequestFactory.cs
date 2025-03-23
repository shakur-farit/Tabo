using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.Weapon.ChangeRequest.Factory
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
					.AddNewWeaponTypeId(typeId)
					.With(x => x.isWeaponChangeRequested = true)
				;
		}
	}
}