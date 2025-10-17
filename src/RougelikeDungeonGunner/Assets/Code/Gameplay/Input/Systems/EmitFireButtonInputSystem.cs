using Code.Gameplay.Input.Service;
using Entitas;

namespace Code.Gameplay.Input.Systems
{
	public class EmitFireButtonInputSystem : IExecuteSystem
	{
		private readonly IMobileInputService _inputService;
		private readonly IGroup<InputEntity> _inputs;

		public EmitFireButtonInputSystem(InputContext input, IMobileInputService inputService)
		{
			_inputService = inputService;
			_inputs = input.GetGroup(InputMatcher
				.AllOf(
					InputMatcher.Input,
          InputMatcher.MobileInput));
		}

		public void Execute()
		{
			foreach (InputEntity input in _inputs) 
				input.isMouseLeftButtonDown = _inputService.GetFireButtonPressed();
		}
	}
}