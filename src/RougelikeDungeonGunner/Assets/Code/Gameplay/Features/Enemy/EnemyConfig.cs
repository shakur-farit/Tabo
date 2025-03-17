using System;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Enemy Config", fileName = "EnemyConfig")]
	public class EnemyConfig : ScriptableObject
	{
		public EnemyTypeId EnemyTypeId;
		public EntityBehaviour PrefabView;
		public RuntimeAnimatorController AnimatorController;
		[Range(1, 100)] public int CurrentHp;
		[Range(1, 100)] public int MaxHp;
		[Range(1, 100)] public int Damage;
		[Range(1, 100)] public int MovementSpeed;

		private void OnValidate()
		{
			if(CurrentHp > MaxHp)
				MaxHp = CurrentHp;
		}
	}
}