using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using System;
using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

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

		public GameEntity CreateWeapon(WeaponId weaponId, int level, GameEntity entity, Vector2 at)
		{
			switch (weaponId)
			{
				case WeaponId.Pistol:
					return CreatePistol(level, entity, at);
			}

			throw new Exception($"Weapon for {weaponId} was not found");
		}

		public GameEntity CreatePistol(int level, GameEntity entity, Vector2 at)
		{
			return CreateWeaponEntity(WeaponId.Pistol, level, entity, at)
				.With(x => x.isPistol = true);
		}

		private GameEntity CreateWeaponEntity(WeaponId weaponId, int level, GameEntity entity, Vector2 at)
		{
			WeaponConfig weaponConfig = _staticDataService.GetWeaponConfig(weaponId);
			WeaponLevel weaponLevel = _staticDataService.GetWeaponLevel(weaponId, level);

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddViewPath("WeaponRotationPoint")
					.AddViewParent(entity)
					.AddWorldPosition(at)
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