using System.Collections.Generic;
using Assets.Code.Gameplay.Features.Aura;
using Assets.Code.Gameplay.Features.Collection;
using Assets.Code.Gameplay.Features.Statuses;
using Assets.Code.Gameplay.Features.Weapon;
using Assets.Code.Infrastructure.View;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Enemy.Configs
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
		[Range(0, 100)] public float AttackRaduis;
		[Range(0, 100)] public float AttackInterlal;
		public CollisionCastSetup CastSetup;
		public List<StatusSetup> StatusSetups;

		private void OnValidate()
		{
			if(CurrentHp > MaxHp)
				MaxHp = CurrentHp;
		}
	}
}