using Assets.Code.Gameplay.Features.Enchants.Behaviours;
using Assets.Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Enchants.Registratrs
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