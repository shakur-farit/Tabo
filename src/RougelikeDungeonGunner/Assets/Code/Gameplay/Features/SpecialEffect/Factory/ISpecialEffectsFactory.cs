using UnityEngine;

namespace Code.Gameplay.Features.Loot
{
	public interface ISpecialEffectsFactory
	{
		GameEntity CreateSpecialEffect(SpecialEffectTypeId typeId, Vector3 at);
	}
}