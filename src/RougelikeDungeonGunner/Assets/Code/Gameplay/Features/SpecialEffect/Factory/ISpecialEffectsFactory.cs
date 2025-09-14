using UnityEngine;

namespace Code.Gameplay.Features.SpecialEffect.Factory
{
	public interface ISpecialEffectsFactory
	{
		GameEntity CreateSpecialEffect(SpecialEffectTypeId typeId, Vector3 at);
	}
}