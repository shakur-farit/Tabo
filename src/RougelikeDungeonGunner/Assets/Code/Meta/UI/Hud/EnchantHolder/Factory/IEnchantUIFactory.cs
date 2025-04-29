using Code.Gameplay.Features.Enchants;
using Code.Meta.UI.Hud.EnchantHolder.Behaviours;
using UnityEngine;

namespace Code.Meta.UI.Hud.EnchantHolder.Factory
{
	public interface IEnchantUIFactory
	{
		EnchantUI CreateEnchantVisual(EnchantTypeId typeId, Transform parent);
	}
}