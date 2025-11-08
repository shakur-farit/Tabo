using System.Collections.Generic;
using Entitas;

namespace Code.Sounds.SoundEffects.Systems
{
  public class PlaySoundEffectReactiveSystem : ReactiveSystem<GameEntity>
  {
    public PlaySoundEffectReactiveSystem(GameContext game) : base(game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
      context.CreateCollector(GameMatcher.AllOf(
        GameMatcher.SoundEffect,
        GameMatcher.AudioClip,
        GameMatcher.AudioSource).Added());

    protected override bool Filter(GameEntity soundEffect) =>
      soundEffect.isSoundEffect && soundEffect.hasAudioSource && soundEffect.hasAudioClip;

    protected override void Execute(List<GameEntity> soundEffects)
    {
      foreach (GameEntity soundEffect in soundEffects)
      {
        soundEffect.AudioSource.clip = soundEffect.AudioClip;
        soundEffect.AudioSource.volume = soundEffect.Volume;
        soundEffect.AudioSource.Play();
      }
    }
  }
}