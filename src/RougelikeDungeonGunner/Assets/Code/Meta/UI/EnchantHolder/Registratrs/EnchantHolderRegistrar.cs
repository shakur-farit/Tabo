using Code.Infrastructure.View.Registrars;
using Code.Meta.UI.Hud.EnchantHolder.Behaviours;
using UnityEngine;

namespace Code.Meta.UI.Hud.EnchantHolder.Registratrs
{
	public class EnchantHolderRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private EnchantHolderBehaviour _enchantHolder;

		public override void RegisterComponents() => 
			Entity.AddEnchantHolder(_enchantHolder);

		public override void UnregisterComponents()
		{
			if (Entity.hasEnchantHolder)
				Entity.RemoveEnchantHolder();
		}
	}
}