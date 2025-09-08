using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class MarkAmmoProcessedOnWeaponFireRangeSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(32);

		private readonly IGroup<GameEntity> _ammo;
		private readonly IGroup<GameEntity> _weapons;

		public MarkAmmoProcessedOnWeaponFireRangeSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.ProducerId,
					GameMatcher.WorldPosition));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.Id,
					GameMatcher.Radius,
					GameMatcher.FirePositionTransform));
		}

		public void Execute()
		{
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer))
			foreach (GameEntity weapon in _weapons)
			{
				if (weapon.Id != ammo.ProducerId)
					continue;

				float distance = (ammo.WorldPosition - weapon.FirePositionTransform.position).magnitude;

				if (distance > weapon.Radius)
					ammo.isProcessed = true;
			}
		}
	}
}