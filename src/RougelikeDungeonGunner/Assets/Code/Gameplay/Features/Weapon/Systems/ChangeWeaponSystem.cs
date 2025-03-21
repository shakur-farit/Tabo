using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class ChangeWeaponSystem : IExecuteSystem
	{
		private readonly IStaticDataService _staticDataService;
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _changeRequests;
		private readonly List<GameEntity> _buffer = new(1);

		public ChangeWeaponSystem(GameContext game, IStaticDataService staticDataService)
		{
			_staticDataService = staticDataService;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon));

			_changeRequests = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.NewWeapon,
					GameMatcher.ReadyToChangeWeapon));
		}

		public void Execute()
		{
			foreach (GameEntity changeRequest in _changeRequests.GetEntities(_buffer))
			{
				WeaponConfig config = _staticDataService.GetWeaponConfig(changeRequest.NewWeapon);
				WeaponLevel level = _staticDataService.GetWeaponLevel(changeRequest.NewWeapon, 1);

				foreach (GameEntity weapon in _weapons)
				{
					weapon
						.ReplaceWeaponTypeId(config.WeaponTypeId)
						.ReplaceAmmoId(config.AmmoId)
						.ReplaceRadius(level.FireRange)
						.ReplaceReloadTime(level.ReloadTime)
						.ReplaceMagazineSize(level.MagazineSize)
						.ReplaceCooldown(level.Cooldown)
						.With(x=> x.SpriteRenderer.sprite = config.WeaponSprite)
						;

					Debug.Log(weapon.WeaponTypeId);
				}

				changeRequest.isReadyToChangeWeapon = false;
			}
		}
	}
}