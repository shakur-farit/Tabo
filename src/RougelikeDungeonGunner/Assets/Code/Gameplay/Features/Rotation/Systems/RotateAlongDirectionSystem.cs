using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement
{
	public class RotateAlongDirectionSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _rotators;

		public RotateAlongDirectionSystem(GameContext game)
		{
			_rotators = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.RotationAvailable,
					GameMatcher.Rotating,
					GameMatcher.Direction));
		}

		public void Execute()
		{
			foreach (GameEntity rotator in _rotators)
			{
				Vector3 dir = rotator.Direction;

				if (dir.sqrMagnitude < 0.001f) 
					continue;

				float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
				rotator.ReplaceRotationAngle(angle);
			}
		}
	}
}