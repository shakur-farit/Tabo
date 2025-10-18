using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Entitas;

namespace Code.Gameplay.Features.Pause.Systems
{
  public class PauseSystem : IExecuteSystem
  {
    private readonly ITimeService _time;
    private readonly IWindowService _windowService;
    private readonly IGroup<InputEntity> _inputs;
    private readonly List<InputEntity> _buffer = new(1);

    public PauseSystem(InputContext input, ITimeService time, IWindowService windowService)
    {
      _time = time;
      _windowService = windowService;
      _inputs = input.GetGroup(InputMatcher
        .AllOf(
          InputMatcher.Input,
          InputMatcher.PauseButtonDown));
    }

    public void Execute()
    {
      foreach (InputEntity input in _inputs.GetEntities(_buffer))
      {
        if (_time.Paused)
        {
          _time.StartTime();
          _windowService.Close(WindowId.PauseWindow);
        }
        else
        {
          _time.StopTime();
          _windowService.Open(WindowId.PauseWindow);
        }

        input.isPauseButtonDown = false;
      }
    }
  }
}