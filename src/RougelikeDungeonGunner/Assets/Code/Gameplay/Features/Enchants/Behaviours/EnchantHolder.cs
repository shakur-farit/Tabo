using System.Collections.Generic;
using Code.Gameplay.Features.Enchants.Factory;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Enchants
{
	public class EnchantHolder : MonoBehaviour
	{
		[SerializeField] private Transform _enchantHolder;

		public List<EnchantVisual> EnchantVisuals { get; } = new();

		private IEnchantVisualFactory _factory;

		[Inject]
		public void Constructor(IEnchantVisualFactory factory) => 
			_factory = factory;

		public void AddEnchantVisual(EnchantTypeId typeId)
		{
			if(EnchantVisualAlreadyHeld(typeId))
				return;

			EnchantVisual enchant = _factory.CreateEnchantVisual(typeId, _enchantHolder);

			EnchantVisuals.Add(enchant);
		}


		public void RemoveEnchantVisual(EnchantTypeId typeId)
		{
			EnchantVisual enchant = EnchantVisuals.Find(e => e.Id == typeId);

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