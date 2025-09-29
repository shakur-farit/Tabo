using UnityEngine;

namespace Code.Gameplay.Features.Door.Factory
{
	public interface IDoorFactory
	{
		GameEntity CreateDoor(DoorTypeId typeId, Vector3 at);
	}
}