using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Hero
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Hero Config", fileName = "HeroConfig")]
	public class HeroConfig : ScriptableObject
	{
		public HeroTypeId HeroTypeId;
		public EntityBehaviour PrefabView;
		public RuntimeAnimatorController AnimatorController;
		[Range(1, 100)] public int CurrentHp;
		[Range(1, 100)] public int MaxHp;
		[Range(1, 100)] public int MovementSpeed;

		private void OnValidate()
		{
			if (CurrentHp > MaxHp)
				MaxHp = CurrentHp;
		}
	}
}