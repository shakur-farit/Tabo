using Entitas;

namespace Code.Meta.Features.Hud.WeaponHolder.Systems
{
	public class UpdateCurrentAmmoCountTextSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _holders;

		public UpdateCurrentAmmoCountTextSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.HeroWeapon,
					GameMatcher.MaxAmmoCount,
					GameMatcher.CurrentAmmoCount));

			_holders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.WeaponHolder));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			foreach (GameEntity holder in _holders)
				holder.WeaponHolder.UpdateCurrentAmmoCountText(weapon.CurrentAmmoCount, weapon.MaxAmmoCount);
		}
	}
}