using System.Collections.Generic;
using Assets.Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Input
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
					Debug.Log("unpaused");
					_time.StartTime();
					input.isPaused = false;
				}
				else
				{
					Debug.Log("paused");
					_time.StopTime();
					input.isPaused = true;
				}
			}
		}
	}
}