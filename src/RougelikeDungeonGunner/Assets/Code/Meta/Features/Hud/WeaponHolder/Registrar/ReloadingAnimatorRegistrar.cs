using Code.Infrastructure.View.Registrars;
using Code.Meta.UI.WeaponHolder.Behaviours;
using UnityEngine;

namespace Code.Meta.UI.WeaponHolder.Registrar
{
	public class ReloadingAnimatorRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private ReloadingAnimator _animator;

		public override void RegisterComponents() =>
			Entity.AddReloadingAnimator(_animator);

		public override void UnregisterComponents()
		{
			if (Entity.hasReloadingAnimator)
				Entity.RemoveReloadingAnimator();
		}
	}
}