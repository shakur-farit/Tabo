using UnityEngine;

namespace Code.Gameplay.Features.Enchants.Factory
{
	public interface IEnchantVisualFactory
	{
		EnchantVisual CreateEnchantVisual(EnchantTypeId typeId, Transform parent);
	}
}