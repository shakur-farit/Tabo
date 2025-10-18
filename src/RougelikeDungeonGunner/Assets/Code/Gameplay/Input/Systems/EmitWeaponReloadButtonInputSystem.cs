using Code.Gameplay.Input.Service;
using Entitas;

namespace Code.Gameplay.Input.Systems
{
  public class EmitWeaponReloadButtonInputSystem : IExecuteSystem
  {
    private readonly IStandaloneInputService _inputService;
    private readonly IGroup<InputEntity> _inputs;

    public EmitWeaponReloadButtonInputSystem(InputContext input, IStandaloneInputService inputService)
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
        input.isWeaponReloadButtonDown = _inputService.GetWeaponReloadButtonDown();
    }
  }
}