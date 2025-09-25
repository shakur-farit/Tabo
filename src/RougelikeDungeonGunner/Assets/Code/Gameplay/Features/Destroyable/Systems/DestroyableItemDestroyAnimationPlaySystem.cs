using Entitas;

namespace Code.Gameplay.Features.Destroyable.Systems
{
	public class DestroyableItemDestroyAnimationPlaySystem : IExecuteSystem
	{
		private readonly GameContext _game;
		private readonly IGroup<GameEntity> _collectors;

		public DestroyableItemDestroyAnimationPlaySystem(GameContext game)
		{
			_game = game;
			_collectors = game.GetGroup(GameMatcher
				.AllOf(GameMatcher.DestroyableTargetsBuffer));
		}

		public void Execute()
		{
			foreach (GameEntity collector in _collectors)
			{
				foreach (int id in collector.DestroyableTargetsBuffer)
				{
					GameEntity destroyable = _game.GetEntityWithId(id);

					if(destroyable.isDestroyed)
						continue;

					if (destroyable.hasDestroyableAnimator)
						destroyable.DestroyableAnimator.PlayDestroy();

          destroyable.isDestroyed = true;
        }
			}
		}
  }
}