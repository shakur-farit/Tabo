using Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.AmmoPattern.Systems
{
	public class RotatePatternSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _patterns;

		public RotatePatternSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_patterns = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AmmoPattern,
					GameMatcher.AmmoTransformsList,
					GameMatcher.PatternCenter,
					GameMatcher.PatternRotateSpeed,
					GameMatcher.PatternRadius));
		}

		public void Execute()
		{
			foreach (GameEntity pattern in _patterns)
			{
				float angleStep = 360f / pattern.AmmoTransformsList.Count;
				float baseAngle = pattern.PatternRotateSpeed * _time.DeltaTime;

				for (int i = 0; i < pattern.AmmoTransformsList.Count; i++)
				{
					float angle = baseAngle + angleStep * i;
					float rad = angle * Mathf.Deg2Rad;

					Vector3 offset = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0f) * pattern.PatternRadius;
					pattern.AmmoTransformsList[i].position = pattern.PatternCenter + offset;
				}
			}
		}
	}
}