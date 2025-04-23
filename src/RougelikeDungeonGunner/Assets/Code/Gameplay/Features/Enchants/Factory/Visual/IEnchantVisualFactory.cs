using UnityEngine;

namespace Code.Gameplay.Features.Enchants.Factory
{
	public interface IEnchantVisualFactory
	{
		GameEntity CreateEnchantVisual(EnchantTypeId typeId, Transform parent);
	}
}