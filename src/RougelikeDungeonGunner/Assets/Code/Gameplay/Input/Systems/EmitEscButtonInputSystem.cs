using Code.Gameplay.Input.Service;
using Entitas;

namespace Code.Gameplay.Input.Systems
{
	public class EmitEscButtonInputSystem : IExecuteSystem
	{
		private readonly IInputService _inputService;
		private readonly IGroup<InputEntity> _inputs;

		public EmitEscButtonInputSystem(InputContext input, IInputService inputService)
		{
			_inputService = inputService;
			_inputs = input.GetGroup(InputMatcher
				.AllOf(
					InputMatcher.Input));
		}

		public void Execute()
		{
			foreach (InputEntity input in _inputs) 
				input.isEscButtonDown = _inputService.GetEscButtonDown();
		}
	}
}