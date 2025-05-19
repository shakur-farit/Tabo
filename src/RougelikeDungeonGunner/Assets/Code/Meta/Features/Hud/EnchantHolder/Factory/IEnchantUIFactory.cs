using Code.Gameplay.Features.Enchants;
using Code.Meta.UI.EnchantHolder.Behaviours;
using UnityEngine;

namespace Code.Meta.UI.EnchantHolder.Factory
{
	public interface IEnchantUIFactory
	{
		EnchantUI CreateEnchantVisual(EnchantTypeId typeId, Transform parent);
	}
}