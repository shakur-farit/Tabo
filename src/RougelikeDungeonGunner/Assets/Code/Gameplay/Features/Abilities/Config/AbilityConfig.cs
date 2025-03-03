using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Abilities.Config
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Ability Config", fileName = "AbilityConfig")]
	public class AbilityConfig : ScriptableObject
	{
		public AbilityId AbilityId;

		public List<AbilityLevel> Levels;
	}
}