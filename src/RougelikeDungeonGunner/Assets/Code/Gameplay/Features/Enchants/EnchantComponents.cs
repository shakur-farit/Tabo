using Entitas;

namespace Code.Gameplay.Features.Enchants
{
	[Game] public class Enchant : IComponent { }
	[Game] public class EnchantTypeIdComponent : IComponent { public EnchantTypeId Value; }
	[Game] public class EnchantDuration : IComponent { public float Value; }
	[Game] public class EnchantTimeLeft : IComponent { public float Value; }
	[Game] public class EnchantAlreadyHeld : IComponent { }
	[Game] public class NewCollectedEnchant : IComponent { }

	[Game] public class EnchantUIComponent : IComponent { }

	[Game] public class PoisonEnchant : IComponent { }
	[Game] public class FreezeEnchant : IComponent { }
	[Game] public class FlameEnchant : IComponent { }
	[Game] public class ExplosiveEnchant : IComponent { }
}