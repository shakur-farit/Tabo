using Code.Gameplay.Features.SpecialEffect.Factory;
using Entitas;

namespace Code.Gameplay.Features.SpecialEffect.Systems
{
	public class CreateSpecialEffectOnShotSystem : IExecuteSystem
	{
		private readonly ISpecialEffectsFactory _factory;
		private readonly IGroup<GameEntity> _weapons;

		public CreateSpecialEffectOnShotSystem(GameContext game, ISpecialEffectsFactory factory)
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
				_factory.CreateSpecialEffect(weapon.SpecialEffectTypeId, weapon.FirePositionTransform.position);
		}
	}
}