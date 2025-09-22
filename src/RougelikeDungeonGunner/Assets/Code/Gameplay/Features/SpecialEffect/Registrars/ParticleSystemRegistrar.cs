using Assets.Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.SpecialEffect.Registrars
{
	public class ParticleSystemRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private ParticleSystem _particleSystem;
		[SerializeField] private ParticleSystemRenderer _particleSystemRenderer;

		public override void RegisterComponents()
		{
			Entity
				.AddParticleSystem(_particleSystem)
				.AddParticleSystemRenderer(_particleSystemRenderer);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasParticleSystem)
				Entity.RemoveParticleSystem();

			if(Entity.hasParticleSystemRenderer)
				Entity.RemoveParticleSystemRenderer();
		}
	}
}