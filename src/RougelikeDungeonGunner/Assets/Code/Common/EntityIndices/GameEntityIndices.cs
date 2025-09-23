using Code.Gameplay.Features.CharacterStats;
using Code.Gameplay.Features.CharacterStats.Indexing;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Statuses.Indexing;
using Entitas;
using Zenject;

namespace Code.Common.EntityIndices
{
	public class GameEntityIndices : IInitializable
	{
		public const string StatusesOfType = "StatusesOfType";
		public const string StatChanges = "StatChanges";

		private readonly GameContext _game;

		public GameEntityIndices(GameContext game)
		{
			_game = game;
		}
		public void Initialize()
		{
		  _game.AddEntityIndex(new EntityIndex<GameEntity, StatusKey>(
			  name: StatusesOfType,
			  _game.GetGroup(GameMatcher
				  .AllOf(
					  GameMatcher.StatusTypeId,
					  GameMatcher.TargetId,
					  GameMatcher.Status,
					  GameMatcher.StatusDuration,
					  GameMatcher.StatusTimeLeft)),
				getKey: GetTargetStatusKey,
				new StatusKeyEqualityComparer()));

		  _game.AddEntityIndex(new EntityIndex<GameEntity, StatKey>(
			  name: StatChanges,
			  _game.GetGroup(GameMatcher
				  .AllOf(
					  GameMatcher.StatChange,
					  GameMatcher.TargetId)),
			  getKey: GetTargetStatKey,
			  new StatKeyEqualityComparer()));
		}

		private StatusKey GetTargetStatusKey(GameEntity entity, IComponent component)
		{
			return new StatusKey(
				(component as TargetId)?.Value ?? entity.TargetId,
				(component as StatusComponents.StatusTypeIdComponent)?.Value ?? entity.StatusTypeId);
		}

		private StatKey GetTargetStatKey(GameEntity entity, IComponent component)
		{
			return new StatKey(
				(component as TargetId)?.Value ?? entity.TargetId,
				(component as StatChange)?.Value ?? entity.StatChange);
		}
	}
}