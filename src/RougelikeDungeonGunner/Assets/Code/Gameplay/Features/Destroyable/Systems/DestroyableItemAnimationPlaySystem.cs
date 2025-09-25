using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Systems
{
	public class DestroyableItemAnimationPlaySystem : IExecuteSystem
	{
		private readonly GameContext _game;
		private readonly IGroup<GameEntity> _collectors;

		public DestroyableItemAnimationPlaySystem(GameContext game)
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

					if (destroyable.hasDestroyableAnimator)
						destroyable.DestroyableAnimator.PlayDestroy();
				}
			}
		}
  }


  public class CreateWallDestroyableItemSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _collectors;

    public CreateWallDestroyableItemSystem(GameContext game)
    {
      _collectors = game.GetGroup(GameMatcher
        .AllOf(GameMatcher.DestroyableTargetsBuffer));
    }

    public void Execute()
    {
      foreach (GameEntity collector in _collectors)
      {

      }
    }
  }
}