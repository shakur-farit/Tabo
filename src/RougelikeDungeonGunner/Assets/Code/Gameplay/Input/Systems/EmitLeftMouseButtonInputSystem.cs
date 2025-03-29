using Code.Gameplay.Input.Service;
using Entitas;

namespace Code.Gameplay.Input.Systems
{
	public class EmitLeftMouseButtonInputSystem : IExecuteSystem
	{
		private readonly IInputService _inputService;
		private readonly IGroup<GameEntity> _inputs;

		public EmitLeftMouseButtonInputSystem(GameContext game, IInputService inputService)
		{
			_inputService = inputService;
			_inputs = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Input));
		}

		public void Execute()
		{
			foreach (GameEntity input in _inputs) 
				input.isMouseLeftButtonDown = _inputService.GetLeftMouseButton();
		}
	}
}