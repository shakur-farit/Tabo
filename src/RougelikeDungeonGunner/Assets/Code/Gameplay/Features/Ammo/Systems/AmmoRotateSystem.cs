using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class AmmoRotateSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _patterns;
		private readonly IGroup<GameEntity> _ammo;

		public AmmoRotateSystem(GameContext game)
		{
			_patterns = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.RotationAngle,
					GameMatcher.Id,
					GameMatcher.AmmoPattern));

			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.AmmoPatternId,
					GameMatcher.Transform,
					GameMatcher.ProducerId));
		}

		public void Execute()
		{
			foreach (GameEntity pattern in _patterns)
			foreach (GameEntity ammo in _ammo)
			{
				if (pattern.Id == ammo.AmmoPatternId)
					ammo.Transform.rotation = Quaternion.Euler(0, 0, pattern.RotationAngle);
			}
		}
	}
}