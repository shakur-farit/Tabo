using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class PrechargeWeaponSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _animators;
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

			_animators = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.ReloadingAnimator));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			foreach (GameEntity animator in _animators)
			{
				if (weapon.PrechargeTimeLeft > 0)
				{
					weapon.ReplacePrechargeTimeLeft(weapon.PrechargeTimeLeft - _time.DeltaTime);
					animator.ReloadingAnimator.AnimatePrecharging(weapon.PrechargeTimeLeft, weapon.PrechargeTime);
				}
				else
				{
					weapon.isPrecharged = true;
					weapon.ReplacePrechargeTimeLeft(weapon.PrechargeTime);
				}
			}
		}
	}
}