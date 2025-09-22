using Assets.Code.Gameplay.Cameras.Provider;
using Assets.Code.Gameplay.Common.Collisions;
using Assets.Code.Gameplay.Common.Physics;
using Assets.Code.Gameplay.Common.Random;
using Assets.Code.Gameplay.Common.Time;
using Assets.Code.Gameplay.Features.Ammo.Factory;
using Assets.Code.Gameplay.Features.Ammo.Services;
using Assets.Code.Gameplay.Features.AmmoPattern.Factory;
using Assets.Code.Gameplay.Features.AStar.Services;
using Assets.Code.Gameplay.Features.Aura.Factory;
using Assets.Code.Gameplay.Features.Dungeon.Factory;
using Assets.Code.Gameplay.Features.Effects.Factory;
using Assets.Code.Gameplay.Features.Enchants.Factory;
using Assets.Code.Gameplay.Features.Enemy.Factory;
using Assets.Code.Gameplay.Features.Enemy.Services;
using Assets.Code.Gameplay.Features.Hero.Factory;
using Assets.Code.Gameplay.Features.Level.Factory;
using Assets.Code.Gameplay.Features.Loot.Factory;
using Assets.Code.Gameplay.Features.Loot.Services;
using Assets.Code.Gameplay.Features.SpecialEffect.Factory;
using Assets.Code.Gameplay.Features.Statuses.Applier;
using Assets.Code.Gameplay.Features.Statuses.Factory;
using Assets.Code.Gameplay.Features.Weapon.Factory;
using Assets.Code.Gameplay.Input.Service;
using Assets.Code.Gameplay.StaticData;
using Assets.Code.Infrastructure.AssetManagement;
using Assets.Code.Infrastructure.Identifiers;
using Assets.Code.Infrastructure.Loading;
using Assets.Code.Infrastructure.States.Factory;
using Assets.Code.Infrastructure.States.GameStates;
using Assets.Code.Infrastructure.States.StateMachine;
using Assets.Code.Infrastructure.Systems;
using Assets.Code.Infrastructure.View.Factory;
using Assets.Code.Meta.Features.Hud.AmmoHolder.Factory;
using Assets.Code.Meta.Features.Hud.EnchantHolder.Factory;
using Assets.Code.Meta.Features.Hud.HeroHeartHolder.Factory;
using Assets.Code.Meta.Features.Shop.Enchant.Factory;
using Assets.Code.Meta.Features.Shop.EnchantUIEntry.Factory;
using Assets.Code.Meta.Features.Shop.Upgrade.Factory;
using Assets.Code.Meta.Features.Shop.Upgrade.Services;
using Assets.Code.Meta.Features.Shop.Weapon.Factory;
using Assets.Code.Meta.Features.Shop.WeaponStatUIEntry.Factory;
using Assets.Code.Meta.UI.Windows.Factory;
using Assets.Code.Meta.UI.Windows.Service;
using Code.Common.EntityIndices;
using Code.Progress.Provider;
using Zenject;

namespace Assets.Code.Infrastructure.Installers
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

		private void BindProgressServices()
		{
			Container.Bind<IProgressProvider>().To<ProgressProvider>().AsSingle();
		}

		private void BindGameplayServices()
		{
			Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();
			Container.Bind<IStatusApplier>().To<StatusApplier>().AsSingle();
			Container.Bind<ILootRandomizerService>().To<LootRandomizerService>().AsSingle();
			Container.Bind<IWeaponUpgradeValidator>().To<WeaponUpgradeValidator>().AsSingle();
			Container.Bind<IWeaponStatsProvider>().To<WeaponStatsProvider>().AsSingle();
			Container.Bind<IWeaponEffectsProvider>().To<WeaponEffectsProvider>().AsSingle();
			Container.Bind<IWeaponUpgrader>().To<WeaponUpgrader>().AsSingle();
			Container.BindInterfacesAndSelfTo<WeaponUpgrades>().AsSingle();
			Container.Bind<IAmmoDirectionProvider>().To<AmmoDirectionProvider>().AsSingle();
			Container.Bind<IEnemySpawnPositionProvider>().To<EnemySpawnPositionProvider>().AsSingle();
			Container.BindInterfacesAndSelfTo<AStarPathfinder>().AsSingle();
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
		}

		private void BindUIServices()
		{
			Container.Bind<IWindowService>().To<WindowService>().AsSingle();
		}

		private void BindSystemFactory()
		{
			Container.Bind<ISystemsFactory>().To<SystemsFactory>().AsSingle();
		}

		private void BindInfrastructureServices()
		{
			Container.BindInterfacesTo<BootstrapInstaller>().FromInstance(this).AsSingle();
			Container.Bind<IIdentifierService>().To<IdentifierService>().AsSingle();
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
			Container.Bind<IInputService>().To<StandaloneInputService>().AsSingle();
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