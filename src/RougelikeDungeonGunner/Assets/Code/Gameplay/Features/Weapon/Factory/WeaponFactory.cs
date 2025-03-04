using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.Weapon.Factory
{
	public class WeaponFactory : IWeaponFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public WeaponFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreatePistol()
		{
			WeaponConfig weaponConfig = _staticDataService.GetWeaponConfig(WeaponId.Pistol);
			WeaponLevel level = _staticDataService.GetWeaponLevel(WeaponId.Pistol, 1);

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddAmmoId(weaponConfig.AmmoId)
					.AddFireRange(level.FireRange)
					.AddReloadTime(level.ReloadTime)
					.AddMagazineSize(level.MagazineSize)
					.AddCooldown(level.Cooldown)
					.With(x => x.isPistol = true)
				;
		}
	}
}