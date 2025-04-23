using Code.Infrastructure.View.Registrars;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.Gameplay.Features.Enchants
{
	public class EnchantVisualEffectRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private EnchantVisualEffect _visualEffect;

		public override void RegisterComponents() => 
			Entity.AddEnchantVisualEffect(_visualEffect);

		public override void UnregisterComponents()
		{
			if(Entity.hasEnchantVisualEffect)
				Entity.RemoveEnchantVisualEffect();
		}
	}
}