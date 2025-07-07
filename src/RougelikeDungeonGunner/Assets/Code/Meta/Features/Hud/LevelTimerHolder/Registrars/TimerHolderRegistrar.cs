using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Meta.Features.Hud.LevelTimerHolder.Registrars
{
	public class TimerHolderRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Behaviours.TimerHolder _timerHolder;

		public override void RegisterComponents() => 
			Entity.AddTimerHolder(_timerHolder);

		public override void UnregisterComponents()
		{
			if (Entity.hasTimerHolder)
				Entity.RemoveTimerHolder();
		}
	}
}