using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Common.Physics;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Collection.Systems
{
	public class CastBoxForCollisionsSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(128);

		private readonly IPhysicsService _physicsService;
		private readonly IGroup<GameEntity> _entities;

		public CastBoxForCollisionsSystem(GameContext game, IPhysicsService physicsService)
		{
			_physicsService = physicsService;
			_entities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.ForwardCastDistance,
					GameMatcher.CastStartPositionTransform,
					GameMatcher.BoxCastWidth,
					GameMatcher.BoxCastHeight,
					GameMatcher.WorldPosition,
					GameMatcher.Direction));
		}

		public void Execute()
		{
			foreach (GameEntity entity in _entities.GetEntities(_buffer))
				entity.isCollisionInFront = HasCollisionsInFront(entity);
		}

		private bool HasCollisionsInFront(GameEntity entity)
		{
			const float margin = 0.1f;

			Vector2 dir = entity.Direction.normalized;

			Vector2 center = (Vector2)entity.CastStartPositionTransform.position + dir * entity.ForwardCastDistance * 0.5f;
			Vector2 halfSize = new(entity.BoxCastWidth * 0.5f, entity.BoxCastHeight * 0.5f);

			Vector2 totalNormal = Vector2.zero;
			bool hasCollision = false;

			bool diagonal = Mathf.Abs(dir.x) > 0.3f && Mathf.Abs(dir.y) > 0.3f;

			if (Mathf.Abs(dir.x) >= Mathf.Abs(dir.y) || diagonal)
			{
				float x = dir.x > 0 ? center.x + halfSize.x : center.x - halfSize.x;
				Vector2 lineStart = new(x, center.y - halfSize.y + margin);
				Vector2 lineEnd = new(x, center.y + halfSize.y - margin);

				Debug.DrawLine(lineStart, lineEnd, Color.magenta, 0f, false);

				GameEntity collisionX = _physicsService.LineCast(lineStart, lineEnd, CollisionLayer.Collision.AsMask());
				if (collisionX != null)
				{
					hasCollision = true;
					totalNormal += new Vector2(dir.x > 0 ? -1f : 1f, 0f);
				}
			}

			if (Mathf.Abs(dir.y) >= Mathf.Abs(dir.x) || diagonal)
			{
				float y = dir.y > 0 ? center.y + halfSize.y : center.y - halfSize.y;
				Vector2 lineStart = new(center.x - halfSize.x + margin, y);
				Vector2 lineEnd = new(center.x + halfSize.x - margin, y);

				Debug.DrawLine(lineStart, lineEnd, Color.yellow, 0f, false);

				GameEntity collisionY = _physicsService.LineCast(lineStart, lineEnd, CollisionLayer.Collision.AsMask());
				if (collisionY != null)
				{
					hasCollision = true;
					totalNormal += new Vector2(0f, dir.y > 0 ? -1f : 1f);
				}
			}

			if (hasCollision && totalNormal != Vector2.zero)
				totalNormal = totalNormal.normalized;

			entity.ReplaceCollisionNormal(totalNormal);
			return hasCollision;
		}
	}
}