using System.Collections.Generic;
using Code.Sounds.SoundEffects.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Systems
{
	public class DestroyableItemDestroyAnimationPlaySystem : IExecuteSystem
	{
    private readonly List<GameEntity> _buffer = new(64);
    private readonly ISoundEffectFactory _soundEffectFactory;
    private readonly IGroup<GameEntity> _destroyableItems;

    public DestroyableItemDestroyAnimationPlaySystem(GameContext game, ISoundEffectFactory soundEffectFactory)
		{
			_soundEffectFactory = soundEffectFactory;
			_destroyableItems = game.GetGroup(GameMatcher
				.AllOf(
          GameMatcher.DestroyableItem,
          GameMatcher.Dead,
          GameMatcher.DestroyableAnimator)
        .NoneOf(GameMatcher.Destroying));
		}

		public void Execute()
		{
			foreach (GameEntity item in _destroyableItems.GetEntities(_buffer))
      {
        item.DestroyableAnimator.PlayDestroy();

        if (item.hasSoundEffectTypeId)
	        _soundEffectFactory.CreateSoundEffect(item.SoundEffectTypeId);

        item.isDestroying = true;
      }
    }
  }
}