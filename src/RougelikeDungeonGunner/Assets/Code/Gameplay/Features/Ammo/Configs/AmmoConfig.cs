using Code.Gameplay.Features.Collection;
using Code.Gameplay.Features.SpecialEffect;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Ammo Config", fileName = "AmmoConfig")]
	public class AmmoConfig : ScriptableObject
	{
		public AmmoTypeId TypeId;
    public SpecialEffectTypeId CollideSpecialEffectTypeId;
    public EntityBehaviour ViewPrefab;
		[Range(0f, 100f)] public float ContactRadius;
		public CollisionCastSetup CastSetup;
  }
}