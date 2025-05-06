using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Meta.UI.Hud.HeartHolder.Registrars
{
	public class HeartUIRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Behaviours.HeartHolder _heartHolder;

		public override void RegisterComponents() => 
			Entity.AddHeartHolder(_heartHolder);

		public override void UnregisterComponents()
		{
			if (Entity.hasHeartHolder)
				Entity.RemoveHeartHolder();
		}
	}
}