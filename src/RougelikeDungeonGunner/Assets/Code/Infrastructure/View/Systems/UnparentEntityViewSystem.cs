using Entitas;

namespace Code.Infrastructure.View
{
	public class UnparentEntityViewSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public UnparentEntityViewSystem(GameContext game)
		{
			_entities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.ViewParent,
					GameMatcher.Unparented));
		}

		public void Execute()
		{
			foreach (GameEntity entity in _entities) 
				entity.ViewParent.SetParent(null);
		}
	}
}