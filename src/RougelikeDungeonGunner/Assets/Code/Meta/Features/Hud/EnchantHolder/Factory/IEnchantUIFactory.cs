using Code.Gameplay.Features.Enchants;
using Code.Meta.Features.Hud.EnchantHolder.Behaviours;
using UnityEngine;

namespace Code.Meta.Features.Hud.EnchantHolder.Factory
{
	public interface IEnchantUIFactory
	{
		EnchantUI CreateEnchantVisual(EnchantTypeId typeId, Transform parent);
	}
}