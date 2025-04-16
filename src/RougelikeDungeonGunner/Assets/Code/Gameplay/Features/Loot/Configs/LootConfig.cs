using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Loot.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Loot Config", fileName = "LootConfig")]

	public class LootConfig : ScriptableObject
	{
		public LootTypeId TypeId;
		public EntityBehaviour ViewPrefab;
		public Sprite Sprite;
		public int Coins;

		public List<EffectSetup> EffectSetups;
		public List<StatusSetup> StatusSetups;
	}
}