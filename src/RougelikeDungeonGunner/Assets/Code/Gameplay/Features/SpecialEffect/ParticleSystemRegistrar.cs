using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Loot
{
	public class ParticleSystemRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private ParticleSystem _particleSystem;

		public override void RegisterComponents() => 
			Entity.AddParticleSystem(_particleSystem);

		public override void UnregisterComponents()
		{
			if (Entity.hasParticleSystem)
				Entity.RemoveParticleSystem();
		}
	}
}