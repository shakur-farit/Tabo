using UnityEngine;

namespace Code.Gameplay.Features.Ammo
{
	public interface IAuraFactory
	{
		GameEntity CreateAura(AuraTypeId typeId, Vector3 at);
	}
}