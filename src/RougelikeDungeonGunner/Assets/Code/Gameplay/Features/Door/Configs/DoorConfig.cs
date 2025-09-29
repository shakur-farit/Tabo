using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Door.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Door Config", fileName = "DoorConfig")]
	public class DoorConfig : ScriptableObject
	{
		public DoorTypeId TypeId;
		public EntityBehaviour ViewPrefab;
	}
}