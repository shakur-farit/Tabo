using Entitas;

namespace Code.Gameplay.Features.Level.Systems
{
  public class UpdateTimerTextSystem : IExecuteSystem
  {
    private const string TimeText = "Time to level start";

    private readonly IGroup<GameEntity> _holders;
    private readonly IGroup<GameEntity> _levels;

    public UpdateTimerTextSystem(GameContext game)
    {
      _holders = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.TimerHolder));

      _levels = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Level,
          GameMatcher.StartingTime,
          GameMatcher.StartingTimeLeft));
    }

    public void Execute()
    {
      foreach (GameEntity holder in _holders)
      foreach (GameEntity level in _levels)
      {
        if (level.isStartingTimeUp)
          holder.TimerHolder.HideTimeText();

        holder.TimerHolder.UpdateTimeText(TimeText, level.StartingTimeLeft);
      }
    }
  }
}