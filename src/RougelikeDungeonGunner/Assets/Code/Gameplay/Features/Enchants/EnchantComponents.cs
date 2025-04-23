using Entitas;

namespace Code.Gameplay.Features.Enchants
{
	[Game] public class Enchant : IComponent { }
	[Game] public class EnchantTypeIdComponent : IComponent { public EnchantTypeId Value; }
	[Game] public class EnchantDuration : IComponent { public float Value; }
	[Game] public class EnchantTimeLeft : IComponent { public float Value; }

	[Game] public class EnchantVisualEffectComponent : IComponent { public EnchantVisualEffect Value; }
	[Game] public class EnchantTimeLeftVisualComponent : IComponent { public EnchantTimeLeftVisual Value; }
	[Game] public class EnchantHolderComponent : IComponent { public EnchantHolder Value; }
	[Game] public class EnchantSpriteRendererComponent : IComponent { public EnchantHolder Value; }

	[Game] public class PoisonEnchant : IComponent { }
	[Game] public class FreezeEnchant : IComponent { }
}