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
		[Range(0f, 100f)] public float ForwardCastDistance;
		[Range(0f, 100f)] public float CastOriginOffset;

		private void OnValidate()
		{
			if (CurrentHp > MaxHp)
				MaxHp = CurrentHp;
		}
	}
}