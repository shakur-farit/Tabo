using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Code.Sounds.Music;
using Code.Sounds.Music.Services;
using Entitas;

namespace Code.Gameplay.Features.Level.Systems
{
  public class CalculateTimeToSpawnEnemiesSystem : IExecuteSystem
  {
    private readonly List<GameEntity> _buffer = new(1);

    private readonly ITimeService _time;
    private readonly IMusicClipSetter _clipSetter;
    private readonly IGroup<GameEntity> _levels;

    public CalculateTimeToSpawnEnemiesSystem(
      GameContext game,
      ITimeService time,
      IMusicClipSetter clipSetter)
    {
      _time = time;
      _clipSetter = clipSetter;
      _levels = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Level,
          GameMatcher.StartingTime,
          GameMatcher.StartingTimeLeft)
        .NoneOf(GameMatcher.StartingTimeUp));
    }

    public void Execute()
    {
      foreach (GameEntity level in _levels.GetEntities(_buffer))
      {
        if (level.StartingTimeLeft <= 0)
        {
          level.isStartingTimeUp = true;
          level.ReplaceStartingTimeLeft(level.StartingTime);
          _clipSetter.SetClip(MusicTypeId.BattleLoopMusic);
        }
        else
        {
          level.ReplaceStartingTimeLeft(level.StartingTimeLeft - _time.DeltaTime);
        }
      }
    }
  }
}