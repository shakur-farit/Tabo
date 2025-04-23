using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Enchants
{
	public class EnchantHolderRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private EnchantHolder _enchantHolder;

		public override void RegisterComponents() =>
			Entity.AddEnchantHolder(_enchantHolder);

		public override void UnregisterComponents()
		{
			if (Entity.hasEnchantHolder)
				Entity.RemoveEnchantHolder();
		}
	}
}