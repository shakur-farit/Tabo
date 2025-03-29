using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class SetShootingByLeftMouseButtonInputSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _inputs;

		public SetShootingByLeftMouseButtonInputSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon));

			_inputs = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Input));
		}

		public void Execute()
		{
			foreach (GameEntity input in _inputs)
			foreach (GameEntity weapon in _weapons)
				weapon.isShooting = input.isMouseLeftButtonDown;
		}
	}
}