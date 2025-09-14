using UnityEngine;

namespace Code.Gameplay.Features.Aura.Factory
{
	public interface IAuraFactory
	{
		GameEntity CreateAura(AuraTypeId typeId, Vector3 at);
	}
}