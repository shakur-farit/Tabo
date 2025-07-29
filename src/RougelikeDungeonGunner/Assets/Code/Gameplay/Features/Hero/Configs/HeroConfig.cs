using Code.Gameplay.Features.TargetCollection;
using Code.Gameplay.Features.Weapon;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Hero Config", fileName = "HeroConfig")]
	public class HeroConfig : ScriptableObject
	{
		public HeroTypeId TypeId;
		public EntityBehaviour ViewPrefab;
		public RuntimeAnimatorController AnimatorController;
		public Sprite HandSprite;
		public WeaponTypeId StartWeapon;
		[Range(1, 100)] public int CurrentHp;
		[Range(1, 100)] public int MaxHp;
		[Range(1, 100)] public int MovementSpeed;

		public CollisionCastSetup CastSetup;

		private void OnValidate()
		{
			if (CurrentHp > MaxHp)
				MaxHp = CurrentHp;
		}
	}
}