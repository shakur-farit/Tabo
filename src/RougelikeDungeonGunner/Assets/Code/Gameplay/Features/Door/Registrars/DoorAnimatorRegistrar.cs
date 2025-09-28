using Code.Gameplay.Features.Destroyable;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon
{
	public class DoorAnimatorRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private DoorAnimator _doorAnimator;

		public override void RegisterComponents() => 
			Entity.AddDoorAnimator(_doorAnimator);

		public override void UnregisterComponents()
		{
			if (Entity.hasDoorAnimator)
				Entity.RemoveDoorAnimator();
		}
	}
}