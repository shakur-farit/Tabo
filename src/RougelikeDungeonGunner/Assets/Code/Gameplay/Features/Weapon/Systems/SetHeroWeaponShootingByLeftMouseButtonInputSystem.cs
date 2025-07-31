using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class SetHeroWeaponShootingByLeftMouseButtonInputSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<InputEntity> _inputs;

		public SetHeroWeaponShootingByLeftMouseButtonInputSystem(GameContext game, InputContext input)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.HeroWeapon));

			_inputs = input.GetGroup(InputMatcher
				.AllOf(
					InputMatcher.Input));
		}

		public void Execute()
		{
			foreach (InputEntity input in _inputs)
			foreach (GameEntity weapon in _weapons)
				weapon.isShooting = input.isMouseLeftButtonDown;
		}
	}
}