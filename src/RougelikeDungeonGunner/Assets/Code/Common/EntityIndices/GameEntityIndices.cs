using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses.Indexing;
using Entitas;
using Zenject;
using static Code.Gameplay.Features.Statuses.StatusComponents;

namespace Code.Common.EntityIndices
{
	public class GameEntityIndices : IInitializable
	{
		public const string StatusesOfType = "StatusesOfType";

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
					  GameMatcher.Duration,
					  GameMatcher.TimeLeft)),
				getKey: GetTargetStatusKey,
				new StatusKeyEqualityComparer()));
		}

		private StatusKey GetTargetStatusKey(GameEntity entity, IComponent component)
		{
			return new StatusKey(
				(component as TargetId)?.Value ?? entity.TargetId,
				(component as StatusTypeIdComponent)?.Value ?? entity.StatusTypeId);
		}
	}
}