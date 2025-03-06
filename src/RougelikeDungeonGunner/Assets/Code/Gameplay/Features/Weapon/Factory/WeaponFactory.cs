using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using System;
using Code.Gameplay.Features.Weapon.Configs;

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

		public GameEntity CreateWeapon(WeaponId weaponId, int level)
		{
			switch (weaponId)
			{
				case WeaponId.Pistol:
					return CreatePistol(level);
			}

			throw new Exception($"Weapon for {weaponId} was not found");
		}

		public GameEntity CreatePistol(int level)
		{
			return CreateWeaponEntity(WeaponId.Pistol, level)
				.With(x => x.isPistol = true);
		}

		private GameEntity CreateWeaponEntity(WeaponId weaponId, int level)
		{
			WeaponConfig weaponConfig = _staticDataService.GetWeaponConfig(weaponId);
			WeaponLevel weaponLevel = _staticDataService.GetWeaponLevel(weaponId, level);

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddAmmoId(weaponConfig.AmmoId)
					.AddRadius(weaponLevel.FireRange)
					.AddReloadTime(weaponLevel.ReloadTime)
					.AddMagazineSize(weaponLevel.MagazineSize)
					.AddCooldown(weaponLevel.Cooldown)
					.With(x => x.isWeapon = true)
					.PutOnCooldown()
				;
		}
	}
}