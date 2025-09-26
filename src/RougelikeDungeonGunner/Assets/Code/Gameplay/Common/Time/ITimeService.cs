using System;

namespace Code.Gameplay.Common.Time
{
  public interface ITimeService
  {
    float DeltaTime { get; }
    DateTime UtcNow { get; }
    bool Paused { get; }
    void StopTime();
    void StartTime();
  }
}