using Code.Gameplay.Input.Service;
using Entitas;

namespace Code.Gameplay.Input.Systems
{
  public class EmitPauseButtonInputSystem : IExecuteSystem
  {
    private readonly IStandaloneInputService _inputService;
    private readonly IGroup<InputEntity> _inputs;

    public EmitPauseButtonInputSystem(InputContext input, IStandaloneInputService inputService)
    {
      _inputService = inputService;
      _inputs = input.GetGroup(InputMatcher
        .AllOf(
          InputMatcher.Input,
          InputMatcher.StandaloneInput));
    }

    public void Execute()
    {
      foreach (InputEntity input in _inputs)
        input.isPauseButtonDown = _inputService.GetPauseButtonDown();
    }
  }
}