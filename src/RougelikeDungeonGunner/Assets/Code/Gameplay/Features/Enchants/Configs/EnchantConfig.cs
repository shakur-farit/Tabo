using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using UnityEngine;

namespace Code.Gameplay.Features.Effects
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Enchant Config", fileName = "EnchantConfig")]
	public class EnchantConfig : ScriptableObject
	{
		public EnchantTypeId TypeId;
		public List<EffectSetup> EffectSetups;
		public List<StatusSetup> StatusSetups;
	}
}