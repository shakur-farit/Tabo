using Code.Infrastructure.View.Registrars;
using Code.Meta.UI.Hud.AmmoHolder.Behaviours;
using UnityEngine;

namespace Code.Meta.UI.Hud.AmmoHolder.Registrars
{
	public class AmmoUIRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private AmmoHolderBehaviour _ammoHolder;

		public override void RegisterComponents() => 
			Entity.AddAmmoHolder(_ammoHolder);

		public override void UnregisterComponents()
		{
			if (Entity.hasAmmoHolder)
				Entity.RemoveAmmoHolder();
		}
	}
}