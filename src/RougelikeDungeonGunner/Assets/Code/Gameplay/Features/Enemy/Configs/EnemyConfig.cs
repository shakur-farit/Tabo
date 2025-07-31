using Code.Gameplay.Features.TargetCollection;
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
		public EntityBehaviour ViewPrefab;
		public RuntimeAnimatorController AnimatorController;
		[Range(1, 100)] public int CurrentHp;
		[Range(1, 100)] public int MaxHp;
		[Range(0, 100)] public int Damage;
		[Range(0, 100)] public int MovementSpeed;
		[Range(0, 100)] public int TargetAmount;
		[Range(0, 100)] public float AttackRaduis;
		[Range(0, 100)] public float AttackInterlal;
		[Range(0, 100)] public float CastOriginOffset;
		public CollisionCastSetup CastSetup;

		private void OnValidate()
		{
			if(CurrentHp > MaxHp)
				MaxHp = CurrentHp;
		}
	}
}