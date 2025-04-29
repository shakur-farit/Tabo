using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Meta.UI.Hud.EnchantHolder.Registratrs
{
	public class EnchantHolderRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Behaviours.EnchantHolder _enchantHolder;

		public override void RegisterComponents() => 
			Entity.AddEnchantHolder(_enchantHolder);

		public override void UnregisterComponents()
		{
			if (Entity.hasEnchantHolder)
				Entity.RemoveEnchantHolder();
		}
	}
}