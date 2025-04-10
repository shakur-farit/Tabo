using Entitas;

namespace Code.Gameplay.Features.Levels
{
	public class MarkWeaponDestructedOnLevelProcessedSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _weapons;

		public MarkWeaponDestructedOnLevelProcessedSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Processed,
					GameMatcher.Level));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
			foreach (GameEntity weapon in _weapons)
			{
				weapon.isDestructed = true;
			}
		}
	}
}