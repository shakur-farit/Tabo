using Code.Gameplay.Features.Level.Systems;
using Code.Infrastructure.Systems;
using Code.Meta.Features.Hud.AmmoHolder.Systems;
using Code.Meta.Features.Hud.CoinsHolder.Systems;
using Code.Meta.Features.Hud.EnchantHolder.Systems;
using Code.Meta.Features.Hud.HeroHeartHolder.Systems;
using Code.Meta.Features.Hud.WeaponHolder.Systems;

namespace Code.Meta.Features.Hud
{
	public sealed class HudFeature : Feature
	{
		public HudFeature(ISystemsFactory systems)
		{
			Add(systems.Create<OpenHudWindowSystem>());
			
			Add(systems.Create<UpdateAmmoUICountInHolderForWeaponWithInfinityAmmoSystem>());
			Add(systems.Create<UpdateAmmoUICountInHolderOnCreateOrReloadWeaponSystem>());
			Add(systems.Create<UpdateAmmoUICountInHolderOnShotSystem>());

			Add(systems.Create<UpdateCoinsTextInHolderSystem>());

			Add(systems.Create<AddEnchantVisualToHolderSystem>());
			Add(systems.Create<UpdateEnchantTimeLeftVisualSystem>());
			Add(systems.Create<RemoveEnchantVisualFromHolderSystem>());

			Add(systems.Create<UpdateHeartUIForHeroInHolderSystem>());

			Add(systems.Create<UpdateTimerTextSystem>());

			Add(systems.Create<SetActiveTextOnInfinityAmmoSystem>());
			Add(systems.Create<SetInactiveTextOnLimitedAmmoSystem>());
			Add(systems.Create<StartWeaponPrechargeAnimationSystem>());
			Add(systems.Create<StartWeaponReloadingAnimationSystem>());
			Add(systems.Create<UpdateCurrentAmmoCountTextSystem>());
			Add(systems.Create<UpdateWeaponIconInHolderSystem>());
			Add(systems.Create<UpdateWeaponNameInHolderSystem>());

			Add(systems.Create<CloseHudWindowSystem>());

			Add(systems.Create<MarkDestructedAmmoHolderOnLevelProcessedSystem>());
			Add(systems.Create<MarkDestructedCoinsHolderOnLevelProcessedSystem>());
			Add(systems.Create<MarkDestructedEnchantHolderOnLevelProcessedSystem>());
			Add(systems.Create<MarkDestructedHeroHeartHolderOnLevelProcessedSystem>());
			Add(systems.Create<MarkDestructedLevelTimerHolderOnLevelProcessedSystem>());
			Add(systems.Create<MarkDestructedWeaponHolderOnLevelProcessedSystem>());
		}
	}
}