using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Loot
{
	public class LootComponents
	{
		[Game] public class LootTypeIdComponent : IComponent { public LootTypeId Value; }
		[Game] public class Pullable : IComponent { }
		[Game] public class Pulling : IComponent { }
		[Game] public class Collected : IComponent { }
		[Game] public class PickupRadius : IComponent { public float Value; }
		[Game] public class LootDropChance : IComponent { public int Value; }
		[Game] public class ExcludedLoot : IComponent { public List<LootTypeId> Value; }
		[Game] public class LootValue : IComponent { public int Value; }

		[Game] public class Coins : IComponent { }
		[Game] public class AmmoLoot : IComponent { }
		[Game] public class MissileLoot : IComponent { }
  }
}