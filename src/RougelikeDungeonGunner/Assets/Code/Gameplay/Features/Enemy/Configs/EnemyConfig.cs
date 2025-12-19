using System.Collections.Generic;
using Code.Gameplay.Features.Aura;
using Code.Gameplay.Features.Collection;
using Code.Gameplay.Features.Loot;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Weapon;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Enemy Config", fileName = "EnemyConfig")]
	public class EnemyConfig : ScriptableObject
	{
		public EnemyTypeId TypeId;
		public WeaponTypeId StartWeapon;
		public AuraTypeId StartAura;
		public EntityBehaviour ViewPrefab;
		public RuntimeAnimatorController AnimatorController;
		[Range(1, 100)] public int CurrentHp;
		[Range(1, 100)] public int MaxHp;
		[Range(0, 100)] public int Damage;
		[Range(0, 100)] public int MovementSpeed;
		[Range(0, 100)] public int TargetAmount;
		[Range(0, 100)] public float TargetDetectingRadius;
		[Range(0, 100)] public float AttackRaduis;
		[Range(0, 100)] public float AttackInterlal;
		[Range(0, 100)] public int LootDropChance;
		[Range(0, 1000)] public int ScoreValue;
    public List<LootTypeId> ExcludedLoot;
    public CollisionCastSetup CastSetup;
		public List<StatusSetup> StatusSetups;

		private void OnValidate()
		{
			if(CurrentHp > MaxHp)
				MaxHp = CurrentHp;
		}
	}
}