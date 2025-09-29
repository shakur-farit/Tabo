using Code.Gameplay.Features.Door.Behaviours;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Door.Registrars
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