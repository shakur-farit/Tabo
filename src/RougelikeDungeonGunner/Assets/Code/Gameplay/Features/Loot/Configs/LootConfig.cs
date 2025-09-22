using System.Collections.Generic;
using Assets.Code.Gameplay.Features.Effects;
using Assets.Code.Gameplay.Features.Enemy;
using Assets.Code.Gameplay.Features.Statuses;
using Assets.Code.Infrastructure.View;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Loot.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Loot Config", fileName = "LootConfig")]

	public class LootConfig : ScriptableObject
	{
		public LootTypeId TypeId;
		public EntityBehaviour ViewPrefab;
		public Sprite Sprite;
		[Range(0f, 100f)] public float DropChanceWeight;
		public List<EnemyTypeId> EnemyTypeFilter;
		[Range(0, 100)] public int CoinValue;

		public List<EffectSetup> EffectSetups;
		public List<StatusSetup> StatusSetups;
	}
}