using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Enchants
{
	public class EnchantVisualsRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private EnchantVisuals _visuals;

		public override void RegisterComponents()
		{
			Entity.AddEnchantVisuals(_visuals);
		}

		public override void UnregisterComponents()
		{
			if(Entity.hasEnchantVisuals)
				Entity.RemoveEnchantVisuals();
		}
	}
}