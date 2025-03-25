using System.Collections.Generic;
using Code.Infrastructure.View;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.Gameplay.Features.Ammo.Config
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Ammo Config", fileName = "AmmoConfig")]
	public class AmmoConfig : ScriptableObject
	{
		[FormerlySerializedAs("AmmoId")] public AmmoTypeId ammoTypeId;
		public EntityBehaviour ViewPrefab;

		public List<AmmoLevel> Levels;
	}
}