using System.Collections.Generic;
using Code.Gameplay.Features.CharacterStats;
using Code.Gameplay.Features.CharacterStats.Indexing;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Statuses.Indexing;
using Entitas;

namespace Code.Common.EntityIndices
{
	public static class ContextIndicesExtensions
	{
		public static HashSet<GameEntity> TargetStatusOfType(this GameContext context, StatusTypeId statusTypeId, int targetId) =>
			((EntityIndex<GameEntity, StatusKey>)context.GetEntityIndex(GameEntityIndices.StatusesOfType))
			.GetEntities(new StatusKey(targetId, statusTypeId));

		public static HashSet<GameEntity> TargetStatChanges(this GameContext context, Stats stat, int targetId) =>
			((EntityIndex<GameEntity, StatKey>)context.GetEntityIndex(GameEntityIndices.StatChanges))
			.GetEntities(new StatKey(targetId, stat));
	}
}