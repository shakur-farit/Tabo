using System.Collections.Generic;
using Code.Sounds.Music.Services;
using Entitas;

namespace Code.Sounds.Music.Systems
{
  public class PlayBossBattleMusicReactiveSystem : ReactiveSystem<GameEntity>
  {
    private readonly IMusicClipSetter _clipSetter;

    public PlayBossBattleMusicReactiveSystem(GameContext game, IMusicClipSetter clipSetter) : base(game) =>
      _clipSetter = clipSetter;

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
      context.CreateCollector(GameMatcher.AllOf(
        GameMatcher.Level,
        GameMatcher.EnemiesDefeated).Added());

    protected override bool Filter(GameEntity level) => level.isLevel && level.isEnemiesDefeated;

    protected override void Execute(List<GameEntity> levels)
    {
      foreach (GameEntity level in levels)
        _clipSetter.SetClip(MusicTypeId.BossBattleMusic);
    }
  }
}