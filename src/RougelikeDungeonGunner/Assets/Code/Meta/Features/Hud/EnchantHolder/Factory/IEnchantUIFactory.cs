using Assets.Code.Gameplay.Features.Enchants;
using Assets.Code.Meta.Features.Hud.EnchantHolder.Behaviours;
using UnityEngine;

namespace Assets.Code.Meta.Features.Hud.EnchantHolder.Factory
{
	public interface IEnchantUIFactory
	{
		EnchantUI CreateEnchantVisual(EnchantTypeId typeId, Transform parent);
	}
}