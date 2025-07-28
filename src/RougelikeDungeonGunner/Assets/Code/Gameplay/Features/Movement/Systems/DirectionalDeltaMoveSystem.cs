using Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement.Systems
{
	public class DirectionalDeltaMoveSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _movers;

		public DirectionalDeltaMoveSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_movers = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Speed,
					GameMatcher.WorldPosition,
					GameMatcher.Rigidbody,
					GameMatcher.Direction,
					GameMatcher.MovementAvailable,
					GameMatcher.Moving)
				.NoneOf(GameMatcher.CollisionInFront));
		}

		public void Execute()
		{
			foreach (GameEntity mover in _movers)
			{
				Vector2 moveDelta = mover.Direction * mover.Speed * _time.DeltaTime;
				mover.Rigidbody.MovePosition(mover.Rigidbody.position + moveDelta);

				mover.ReplaceWorldPosition(mover.Rigidbody.position);
			}
		}
	}
}