using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class StunWeaponOnOwnerStunnedSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weaponeds;
		private readonly IGroup<GameEntity> _weapons;

		public StunWeaponOnOwnerStunnedSystem(GameContext game)
		{
			_weaponeds = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weaponed,
					GameMatcher.Id));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponOwnerId));
		}

		public void Execute()
		{
			foreach (GameEntity weaponeds in _weaponeds)
			foreach (GameEntity weapon in _weapons)
			{
				if (weaponeds.Id == weapon.WeaponOwnerId)
					weapon.isStunned = weaponeds.isStunned;
			}
		}
	}
}