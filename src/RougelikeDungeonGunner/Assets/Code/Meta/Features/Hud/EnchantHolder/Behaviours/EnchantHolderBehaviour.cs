using System.Collections.Generic;
using Code.Gameplay.Features.Enchants;
using Code.Meta.Features.Hud.EnchantHolder.Factory;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Hud.EnchantHolder.Behaviours
{
	public class EnchantHolderBehaviour : MonoBehaviour
	{
		[SerializeField] private Transform _enchantHolder;

		public List<EnchantUI> EnchantVisuals { get; } = new();

		private IEnchantUIFactory _factory;

		[Inject]
		public void Constructor(IEnchantUIFactory factory) => 
			_factory = factory;

		public void AddEnchantVisual(EnchantTypeId typeId)
		{
			if(EnchantVisualAlreadyHeld(typeId))
				return;

			EnchantUI enchant = _factory.CreateEnchantVisual(typeId, _enchantHolder);

			EnchantVisuals.Add(enchant);
		}


		public void RemoveEnchantVisual(EnchantTypeId typeId)
		{
			EnchantUI enchant = EnchantVisuals.Find(e => e.Id == typeId);

			if (enchant != null)
			{
				EnchantVisuals.Remove(enchant);
				Destroy(enchant.gameObject);
			}
		}

		private bool EnchantVisualAlreadyHeld(EnchantTypeId typeId) => 
			EnchantVisuals.Find(e => e.Id == typeId) != null;
	}
}