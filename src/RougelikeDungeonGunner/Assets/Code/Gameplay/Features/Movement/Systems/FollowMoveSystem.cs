using Entitas;

namespace Code.Gameplay.Features.Movement.Systems
{
	public class FollowMoveSystem : IExecuteSystem
	{
		private readonly GameContext _game;
		private readonly IGroup<GameEntity> _followers;

		public FollowMoveSystem(GameContext game)
		{
			_game = game;
			_followers = game.GetGroup(GameMatcher.AllOf(
				GameMatcher.FollowMovement,
				GameMatcher.WorldPosition,
				GameMatcher.FollowTargetId,
				GameMatcher.MovementAvailable,
				GameMatcher.Moving)
				.NoneOf(GameMatcher.FollowMovementYAxisOffset,
			GameMatcher.FollowMovementXAxisOffset));
		}

		public void Execute()
		{
			foreach (GameEntity follower in _followers)
			{
				GameEntity target = _game.GetEntityWithId(follower.FollowTargetId);

				if (target != null && target.hasWorldPosition) 
					follower.ReplaceWorldPosition(target.WorldPosition);
			}
		}
	}
}