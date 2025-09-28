using UnityEngine;

namespace Code.Gameplay.Features.Weapon
{
	public interface IDoorFactory
	{
		GameEntity CreateDoor(DoorTypeId typeId, Vector3 at);
	}
}