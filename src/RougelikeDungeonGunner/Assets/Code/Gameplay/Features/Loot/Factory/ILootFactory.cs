using UnityEngine;

namespace Code.Gameplay.Features.Loot.Factory
{
	public interface ILootFactory
	{
		GameEntity CreateLoot(LootTypeId typeId, Vector3 at);
	}
}