using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class ReloadWeaponSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public ReloadWeaponSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.MagazineSize,
					GameMatcher.ReloadTime,
					GameMatcher.ReloadTimeLeft,
					GameMatcher.Reloading
					));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				if (weapon.ReloadTimeLeft > 0)
				{
					weapon.ReplaceReloadTimeLeft(weapon.ReloadTimeLeft - _time.DeltaTime);
				}
				else
				{
					weapon.ReplaceCurrentAmmoAmount(weapon.MagazineSize);
					weapon.ReplaceReloadTimeLeft(weapon.ReloadTime);
					weapon.isMagazineNotEmpty = true;
					weapon.isReloading = false;
				}
			}
		}
	}
}