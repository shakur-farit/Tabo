using Entitas;

namespace Code.Gameplay.Features.SpecialEffect.Systems
{
	public class SpecialEffectTargetFollowSystem : IExecuteSystem
	{
		private readonly GameContext _game;
		private readonly IGroup<GameEntity> _specialEffects;

		public SpecialEffectTargetFollowSystem(GameContext game)
		{
			_game = game;
			_specialEffects = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.SpecialEffect,
					GameMatcher.WorldPosition,
					GameMatcher.SpecialEffectPositionOffset,
					GameMatcher.FollowerSpecialEffect,
					GameMatcher.TargetId));
		}

		public void Execute()
		{
			foreach (GameEntity specialEffect in _specialEffects)
			{
				GameEntity target = _game.GetEntityWithId(specialEffect.TargetId);

				specialEffect.ReplaceWorldPosition(
					new(
						target.WorldPosition.x + specialEffect.SpecialEffectPositionOffset.x,
						target.WorldPosition.y + specialEffect.SpecialEffectPositionOffset.y,
						target.WorldPosition.z + specialEffect.SpecialEffectPositionOffset.z));
			}
		}
	}
}