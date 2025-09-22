using Assets.Code.Meta.Features.Hud.AmmoHolder.Behaviours;
using Assets.Code.Meta.Features.Hud.CoinsHolder.Behaviours;
using Assets.Code.Meta.Features.Hud.EnchantHolder.Behaviours;
using Assets.Code.Meta.Features.Hud.HeroHeartHolder.Behaviours;
using Assets.Code.Meta.Features.Hud.LevelTimerHolder.Behaviours;
using Assets.Code.Meta.Features.Hud.WeaponHolder.Behaviours;
using Entitas;

namespace Assets.Code.Meta.Features.Hud
{
	[Game] public class AmmoHolderComponent : IComponent { public AmmoHolderBehaviour Value; }
	[Game] public class CoinsHolderComponent : IComponent { public CoinsHolderBehaviour Value; }
	[Game] public class EnchantHolderComponent : IComponent { public EnchantHolderBehaviour Value; }
	[Game] public class HeartHolderComponent : IComponent { public HeartHolder Value; }
	[Game] public class WeaponHolderComponent : IComponent { public WeaponHolderBehaviour Value; }
	[Game] public class ReloadingAnimatorComponent : IComponent { public ReloadingAnimator Value; }
	[Game] public class TimerHolderComponent : IComponent { public TimerHolder Value; }
}