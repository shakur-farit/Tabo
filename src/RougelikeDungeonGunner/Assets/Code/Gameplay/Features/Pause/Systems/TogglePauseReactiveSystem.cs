using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Pause.Systems
{
	public class TogglePauseReactiveSystem : ReactiveSystem<InputEntity>
	{
		private readonly ITimeService _time;

		public TogglePauseReactiveSystem(InputContext context, ITimeService time) : base(context) => 
			_time = time;

		protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
		{
			return context.CreateCollector(InputMatcher.AllOf(
					InputMatcher.Input,
					InputMatcher.EscButtonDown)
				.Added());
		}

		protected override bool Filter(InputEntity input) => 
			input.isInput && input.isEscButtonDown;

		protected override void Execute(List<InputEntity> inputs)
		{
			foreach (InputEntity input in inputs)
			{
				if (input.isPaused)
				{
					_time.StartTime();
					input.isPaused = false;
				}
				else
				{
					_time.StopTime();
					input.isPaused = true;
				}
			}
		}
	}
}