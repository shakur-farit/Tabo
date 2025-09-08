using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement.Systems
{
	public class FollowMoveWithYAxisOffsetSystem : IExecuteSystem
	{
		private readonly GameContext _game;
		private readonly IGroup<GameEntity> _followers;

		public FollowMoveWithYAxisOffsetSystem(GameContext game)
		{
			_game = game;
			_followers = game.GetGroup(GameMatcher.AllOf(
				GameMatcher.FollowMovement,
				GameMatcher.WorldPosition,
				GameMatcher.FollowTargetId,
				GameMatcher.MovementAvailable,
				GameMatcher.Moving,
				GameMatcher.FollowMovementYAxisOffset));
		}

		public void Execute()
		{
			foreach (GameEntity follower in _followers)
			{
				GameEntity target = _game.GetEntityWithId(follower.FollowTargetId);

				if (target != null && target.hasWorldPosition)
					follower.ReplaceWorldPosition(new Vector3(
						target.WorldPosition.x, 
						target.WorldPosition.y + follower.FollowMovementYAxisOffset));
			}
		}
	}
}