using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Loot
{
	public class CreateSpecialEffectSystem : IExecuteSystem
	{
		private readonly ISpecialEffectsFactory _factory;
		private readonly IGroup<GameEntity> _weapons;

		public CreateSpecialEffectSystem(GameContext game, ISpecialEffectsFactory factory)
		{
			_factory = factory;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.Shot,
					GameMatcher.FirePositionTransform,
					GameMatcher.SpecialEffectTypeId));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
				_factory.CreateSpecialEffect(weapon.SpecialEffectTypeId, weapon.FirePositionTransform.position);
			}
		}
	}
}