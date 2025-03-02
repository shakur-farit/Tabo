using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Abilities
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Ability Configs", fileName = "AbilityConfig")]
	public class AbilityConfig : ScriptableObject
	{
		public AbilityId AbilityId;

		public List<AbilityLevel> Levels;
	}
}