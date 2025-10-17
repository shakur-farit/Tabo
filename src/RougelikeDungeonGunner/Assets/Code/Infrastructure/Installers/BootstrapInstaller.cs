using Code.Common.EntityIndices;
using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Common.Collisions;
using Code.Gameplay.Common.Physics;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Ammo.Services;
using Code.Gameplay.Features.AmmoPattern.Factory;
using Code.Gameplay.Features.AStar.Services;
using Code.Gameplay.Features.Aura.Factory;
using Code.Gameplay.Features.Destroyable.Factory;
using Code.Gameplay.Features.Door.Factory;
using Code.Gameplay.Features.Dungeon.Factory;
using Code.Gameplay.Features.Dungeon.Services;
using Code.Gameplay.Features.Effects.Factory;
using Code.Gameplay.Features.Enchants.Factory;
using Code.Gameplay.Features.Enemy.Factory;
using Code.Gameplay.Features.Enemy.Services;
using Code.Gameplay.Features.Hero.Factory;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Level.Factory;
using Code.Gameplay.Features.Level.Services;
using Code.Gameplay.Features.Loot.Factory;
using Code.Gameplay.Features.Loot.Services;
using Code.Gameplay.Features.SpecialEffect.Factory;
using Code.Gameplay.Features.Statuses.Applier;
using Code.Gameplay.Features.Statuses.Factory;
using Code.Gameplay.Features.Weapon.Factory;
using Code.Gameplay.Features.Weapon.Services;
using Code.Gameplay.Input.Service;
using Code.Gameplay.StaticData;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Identifiers;
using Code.Infrastructure.Loading;
using Code.Infrastructure.ObjectPool.Services;
using Code.Infrastructure.Services;
using Code.Infrastructure.States.Factory;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View.Factory;
using Code.Meta.Features.HeroSelector.Factory;
using Code.Meta.Features.Hud.AmmoHolder.Factory;
using Code.Meta.Features.Hud.EnchantHolder.Factory;
using Code.Meta.Features.Hud.HeroHeartHolder.Factory;
using Code.Meta.Features.Shop.Enchant.Factory;
using Code.Meta.Features.Shop.EnchantUIEntry.Factory;
using Code.Meta.Features.Shop.EnchantUIEntry.Services;
using Code.Meta.Features.Shop.Services;
using Code.Meta.Features.Shop.Upgrade.Factory;
using Code.Meta.Features.Shop.Upgrade.Services;
using Code.Meta.Features.Shop.Weapon.Factory;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Factory;
using Code.Meta.UI.Windows.Factory;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using Code.Sounds.Music.Services;
using Code.Sounds.Services;
using Code.Sounds.SoundEffects.Factory;
using Zenject;

namespace Code.Infrastructure.Installers
{
	public class BootstrapInstaller : MonoInstaller, ICoroutineRunner, IInitializable
	{
		public override void InstallBindings()
		{
			BindStateMachine();
			BindStateFactory();
			BindGameStates();
			BindInputService();
			BindSystemFactory();
			BindInfrastructureServices();
			BindAssetManagementServices();
			BindCommonServices();
			BindContexts();
			BindGameplayServices();
			BindGameplayFactories();
			BindUIFactories();
			BindUIServices();
			BindSoundsServices();
			BindSoundsFactories();
			BindCameraProvider();
			BindProgressServices();
			BindEntityIndices();
		}

		private void BindStateMachine()
		{
			Container.BindInterfacesAndSelfTo<GameStateMachine>().AsSingle();
		}

		private void BindStateFactory()
		{
			Container.BindInterfacesAndSelfTo<StateFactory>().AsSingle();
		}

		private void BindGameStates()
		{
			Container.BindInterfacesAndSelfTo<BootstrapState>().AsSingle();
			Container.BindInterfacesAndSelfTo<InitializeProgressState>().AsSingle();
			Container.BindInterfacesAndSelfTo<LoadStaticDataState>().AsSingle();
			Container.BindInterfacesAndSelfTo<ObjectPoolWarmupState>().AsSingle();
			Container.BindInterfacesAndSelfTo<LoadingHomeScreenState>().AsSingle();
			Container.BindInterfacesAndSelfTo<HomeScreenEnterState>().AsSingle();
			Container.BindInterfacesAndSelfTo<HomeScreenState>().AsSingle();
			Container.BindInterfacesAndSelfTo<LoadingBattleState>().AsSingle();
			Container.BindInterfacesAndSelfTo<BattleEnterState>().AsSingle();
			Container.BindInterfacesAndSelfTo<BattleLoopState>().AsSingle();
			Container.BindInterfacesAndSelfTo<LevelCompleteState>().AsSingle();
			Container.BindInterfacesAndSelfTo<GameOverState>().AsSingle();
		}

		private void BindContexts()
		{
			Container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();

			Container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
			Container.Bind<InputContext>().FromInstance(Contexts.sharedInstance.input).AsSingle();
			Container.Bind<MetaContext>().FromInstance(Contexts.sharedInstance.meta).AsSingle();
		}

		private void BindCameraProvider()
		{
			Container.BindInterfacesAndSelfTo<CameraProvider>().AsSingle();
		}

		private void BindProgressServices() => 
			Container.Bind<IProgressProvider>().To<ProgressProvider>().AsSingle();

		private void BindGameplayServices()
		{
			Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();
			Container.Bind<IStatusApplier>().To<StatusApplier>().AsSingle();
			Container.Bind<ILootDropChanceService>().To<LootDropChanceService>().AsSingle();
			Container.Bind<ILootRandomizerService>().To<LootRandomizerService>().AsSingle();
			Container.Bind<IWeaponUpgradeValidator>().To<WeaponUpgradeValidator>().AsSingle();
			Container.Bind<IWeaponStatsProvider>().To<WeaponStatsProvider>().AsSingle();
			Container.Bind<IWeaponEffectsProvider>().To<WeaponEffectsProvider>().AsSingle();
			Container.Bind<IWeaponUpgrader>().To<WeaponUpgrader>().AsSingle();
			Container.Bind<IWeaponReloadService>().To<WeaponReloadService>().AsSingle();
			Container.BindInterfacesAndSelfTo<WeaponUpgrades>().AsSingle();
			Container.Bind<IAmmoDirectionProvider>().To<AmmoDirectionProvider>().AsSingle();
			Container.Bind<IValidPositionsProvider>().To<ValidPositionsProvider>().AsSingle();
			Container.Bind<IEnemySpawnPositionProvider>().To<EnemySpawnPositionProvider>().AsSingle();
      Container.BindInterfacesAndSelfTo<AStarPathfinder>().AsSingle();
      Container.Bind<ICoinService>().To<CoinService>().AsSingle();
      Container.Bind<IWeaponStatusSetupProvider>().To<WeaponStatusSetupProvider>().AsSingle();
      Container.Bind<ILevelService>().To<LevelService>().AsSingle();
      Container.Bind<ICurrentHeroWeaponProvider>().To<CurrentHeroWeaponProvider>().AsSingle();
      Container.Bind<ICurrentHeroTypeIdProvider>().To<CurrentHeroTypeIdProvider>().AsSingle();
      Container.Bind<ICurrentHeroHpProvider>().To<CurrentHeroHpProvider>().AsSingle();
    }

		private void BindGameplayFactories()
		{
			Container.Bind<IEntityViewFactory>().To<EntityViewFactory>().AsSingle();
			Container.Bind<IHeroFactory>().To<HeroFactory>().AsSingle();
			Container.Bind<IEnemyFactory>().To<EnemyFactory>().AsSingle();
			Container.Bind<IAmmoFactory>().To<AmmoFactory>().AsSingle();
			Container.Bind<IWeaponFactory>().To<WeaponFactory>().AsSingle();
			Container.Bind<IEffectFactory>().To<EffectFactory>().AsSingle();
			Container.Bind<IStatusFactory>().To<StatusFactory>().AsSingle();
			Container.Bind<ILevelFactory>().To<LevelFactory>().AsSingle();
			Container.Bind<IDungeonFactory>().To<DungeonFactory>().AsSingle();
			Container.Bind<ILootFactory>().To<LootFactory>().AsSingle();
			Container.Bind<IEnchantFactory>().To<EnchantFactory>().AsSingle();
			Container.Bind<IAuraFactory>().To<AuraFactory>().AsSingle();
			Container.Bind<ISpecialEffectsFactory>().To<SpecialEffectsFactory>().AsSingle();
			Container.Bind<IAmmoPatternFactory>().To<AmmoPatternFactory>().AsSingle();
			Container.Bind<IDestroyableItemFactory>().To<DestroyableItemFactory>().AsSingle();
			Container.Bind<IDoorFactory>().To<DoorFactory>().AsSingle();
		}

		private void BindUIFactories()
		{
			Container.Bind<IEnchantUIFactory>().To<EnchantUIFactory>().AsSingle();
			Container.Bind<IAmmoUIFactory>().To<AmmoUIFactory>().AsSingle();
			Container.Bind<IHeartUIFactory>().To<HeartUIFactory>().AsSingle();
			Container.Bind<IWindowFactory>().To<WindowFactory>().AsSingle();
			Container.Bind<IWeaponShopItemFactory>().To<WeaponShopItemFactory>().AsSingle();
			Container.Bind<IEnchantShopItemFactory>().To<EnchantShopItemFactory>().AsSingle();
			Container.Bind<IWeaponUpgradeShopItemFactory>().To<WeaponUpgradeShopItemFactory>().AsSingle();
			Container.Bind<IWeaponStatUIEntryItemFactory>().To<WeaponStatUIEntryItemFactory>().AsSingle();
			Container.Bind<IEnchantUIEntryFactory>().To<EnchantUIEntryFactory>().AsSingle();
			Container.Bind<IWeaponEnchantStatUIEntryFactory>().To<WeaponEnchantStatUIEntryFactory>().AsSingle();
			Container.Bind<IHeroSelectorFactory>().To<HeroSelectorFactory>().AsSingle();
		}

		private void BindUIServices()
		{
			Container.Bind<IWindowService>().To<WindowService>().AsSingle();
      Container.BindInterfacesAndSelfTo<ShopService>().AsSingle();
      Container.Bind<ISelectedEnchantUIEntryProvider>().To<SelectedEnchantUIEntryProvider>().AsSingle();
    }

		private void BindSoundsServices()
		{
			Container.BindInterfacesAndSelfTo<MusicProvider>().AsSingle();
			Container.BindInterfacesAndSelfTo<SoundsVolumeService>().AsSingle();
		}

    private void BindSoundsFactories() => 
      Container.Bind<ISoundEffectFactory>().To<SoundEffectFactory>().AsSingle();

    private void BindSystemFactory()
		{
			Container.Bind<ISystemsFactory>().To<SystemsFactory>().AsSingle();
		}

		private void BindInfrastructureServices()
		{
			Container.BindInterfacesTo<BootstrapInstaller>().FromInstance(this).AsSingle();
			Container.Bind<IIdentifierService>().To<IdentifierService>().AsSingle();
			Container.Bind<IQuitGameService>().To<QuitGameService>().AsSingle();
			Container.Bind<IObjectPoolService>().To<ObjectPoolService>().AsSingle();
			Container.Bind<IObjectPoolWarmUpper>().To<ObjectPoolWarmUpper>().AsSingle();
		}

		private void BindAssetManagementServices()
		{
			Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
		}

		private void BindCommonServices()
		{
			Container.Bind<IRandomService>().To<UnityRandomService>().AsSingle();
			Container.Bind<ICollisionRegistry>().To<CollisionRegistry>().AsSingle();
			Container.Bind<IPhysicsService>().To<PhysicsService>().AsSingle();
			Container.Bind<ITimeService>().To<UnityTimeService>().AsSingle();
			Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
		}

		private void BindInputService()
		{
      Container.Bind<IInputService>().To<InputService>().AsSingle();
      Container.Bind<IStandaloneInputService>().To<StandaloneInputService>().AsSingle();
      Container.Bind<IMobileInputService>().To<MobileInputService>().AsSingle();
    }

    public void BindEntityIndices()
		{
			Container.BindInterfacesAndSelfTo<GameEntityIndices>().AsSingle();
		}

		public void Initialize()
		{
			Container.Resolve<IGameStateMachine>().Enter<BootstrapState>();
		}
	}
}