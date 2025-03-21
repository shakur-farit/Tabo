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

		public GameEntity CreateWeapon(WeaponTypeId weaponTypeId, int level, GameEntity parentEntity, Vector2 at)
		{
			switch (weaponTypeId)
			{
				case WeaponTypeId.Pistol:
					return CreatePistol(level, parentEntity, at);
			}

			throw new Exception($"Weapon for {weaponTypeId} was not found");
		}

		public GameEntity CreatePistol(int level, GameEntity parentEntity, Vector2 at) =>
			CreateWeaponEntity(WeaponTypeId.Pistol, level, parentEntity, at)
				.With(x => x.isPistol = true)
			;

		private GameEntity CreateWeaponEntity(WeaponTypeId weaponTypeId, int weaponLevel, GameEntity parentEntity, Vector2 at)
		{
			WeaponConfig config = _staticDataService.GetWeaponConfig(weaponTypeId);
			WeaponLevel level = _staticDataService.GetWeaponLevel(weaponTypeId, weaponLevel);

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWeaponTypeId(weaponTypeId)
					.AddViewPrefab(config.PrefabView)
					.AddViewParent(parentEntity)
					.AddWorldPosition(at)
					.AddAmmoId(config.AmmoId)	
					.AddRadius(level.FireRange)
					.AddReloadTime(level.ReloadTime)
					.AddMagazineSize(level.MagazineSize)
					.AddCooldown(level.Cooldown)
					.With(x => x.isWeapon = true)
					.With(x => x.isReadyToCollectTargets = true)
					.PutOnCooldown()
				;
		}
	}
}