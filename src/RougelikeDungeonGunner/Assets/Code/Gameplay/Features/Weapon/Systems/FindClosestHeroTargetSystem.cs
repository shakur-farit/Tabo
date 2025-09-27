using Entitas;
using System.Collections.Generic;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class FindClosestHeroTargetSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGroup<GameEntity> _targets;
		private readonly IGroup<GameEntity> _weapons;

		public FindClosestHeroTargetSystem(GameContext game)
		{
			_targets = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.HeroWeapon,
					GameMatcher.Radius,
					GameMatcher.RotationPointTransform));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
				float closestDistance = float.MaxValue;
        GameEntity closestTarget = null;
        
				foreach (GameEntity target in _targets.GetEntities(_buffer))
        {
          float distance = (target.WorldPosition - weapon.RotationPointTransform.position).magnitude;

					if (distance <= weapon.Radius && distance < closestDistance)
					{
						closestDistance = distance;
						weapon.ReplaceClosestTargetPosition(target.WorldPosition);

            closestTarget = target;
          }
        }

        if (closestTarget != null)
          closestTarget.isClosestTarget = true;
      }
		}
	}
}