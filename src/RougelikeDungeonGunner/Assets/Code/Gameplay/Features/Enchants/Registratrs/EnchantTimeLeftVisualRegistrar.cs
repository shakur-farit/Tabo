using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Enchants
{
	public class EnchantTimeLeftVisualRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private EnchantTimeLeftVisual _timeLeftVisual;

		public override void RegisterComponents() =>
			Entity.AddEnchantTimeLeftVisual(_timeLeftVisual);

		public override void UnregisterComponents()
		{
			if (Entity.hasEnchantTimeLeftVisual)
				Entity.RemoveEnchantTimeLeftVisual();
		}
	}
}