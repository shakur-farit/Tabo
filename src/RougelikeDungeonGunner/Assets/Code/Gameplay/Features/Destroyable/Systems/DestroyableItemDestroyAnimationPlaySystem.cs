using Code.Gameplay.Features.Music;
using Code.Sounds.SoundEffects.Factory;
using Entitas;

namespace Code.Gameplay.Features.Destroyable.Systems
{
	public class DestroyableItemDestroyAnimationPlaySystem : IExecuteSystem
	{
		private readonly GameContext _game;
		private readonly ISoundEffectFactory _soundEffectFactory;
		private readonly IGroup<GameEntity> _collectors;

		public DestroyableItemDestroyAnimationPlaySystem(GameContext game, ISoundEffectFactory soundEffectFactory)
		{
			_game = game;
			_soundEffectFactory = soundEffectFactory;
			_collectors = game.GetGroup(GameMatcher
				.AllOf(GameMatcher.DestroyableTargetsBuffer));
		}

		public void Execute()
		{
			foreach (GameEntity collector in _collectors)
      foreach (int id in collector.DestroyableTargetsBuffer)
      {
        GameEntity destroyable = _game.GetEntityWithId(id);

				if(destroyable.isDestroying)
					continue;

        if(destroyable.hasDestroyableAnimator)
          destroyable.DestroyableAnimator.PlayDestroy();

        if (destroyable.hasSoundEffectTypeId)
	        _soundEffectFactory.CreateSoundEffect(destroyable.SoundEffectTypeId);

        destroyable.isDestroying = true;
      }
    }
  }
}