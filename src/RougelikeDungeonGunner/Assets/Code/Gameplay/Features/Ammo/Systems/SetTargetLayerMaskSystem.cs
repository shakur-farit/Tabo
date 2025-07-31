using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class SetTargetLayerMaskSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _ammo;
		private readonly IGroup<GameEntity> _weapons;

		public SetTargetLayerMaskSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponOwnerTypeId));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			foreach (GameEntity ammo in _ammo)
			{
				if (weapon.WeaponOwnerTypeId == WeaponOwnerTypeId.Hero)
					ammo.ReplaceTargetLayerMask(CollisionLayer.Enemy.AsMask());
				else if (weapon.WeaponOwnerTypeId == WeaponOwnerTypeId.Enemy)
					ammo.ReplaceTargetLayerMask(CollisionLayer.Hero.AsMask());
			}
		}
	}
}