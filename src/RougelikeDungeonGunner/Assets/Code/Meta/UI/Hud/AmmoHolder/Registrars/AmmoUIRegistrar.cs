using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Meta.UI.Hud.AmmoHolder.Registrars
{
	public class AmmoUIRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Behaviours.AmmoHolder _ammoHolder;

		public override void RegisterComponents() => 
			Entity.AddAmmoHolder(_ammoHolder);

		public override void UnregisterComponents()
		{
			if (Entity.hasAmmoHolder)
				Entity.RemoveAmmoHolder();
		}
	}
}