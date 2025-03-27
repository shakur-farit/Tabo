using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class PrechargeWeaponSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public PrechargeWeaponSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.PrechargeTime,
					GameMatcher.PrechargeTimeLeft,
					GameMatcher.ReadyToShoot)
				.NoneOf(GameMatcher.Precharged));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				if(weapon.PrechargeTimeLeft > 0)
				{
					weapon.ReplacePrechargeTimeLeft(weapon.PrechargeTimeLeft - _time.DeltaTime);
					Debug.Log(weapon.PrechargeTimeLeft);
				}
				else
				{
					weapon.isPrecharged = true;
					weapon.ReplacePrechargeTimeLeft(weapon.PrechargeTime);
					Debug.Log(weapon.isPrecharged);
				}
			}
		}
	}
}