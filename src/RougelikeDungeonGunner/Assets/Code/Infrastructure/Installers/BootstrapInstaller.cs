using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Common.Collisions;
using Code.Gameplay.Common.Physics;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Abilities.Factory;
using Code.Gameplay.Features.Armaments;
using Code.Gameplay.Features.Enemy.Factory;
using Code.Gameplay.Features.Hero.Factory;
using Code.Gameplay.Input.Service;
using Code.Gameplay.Levels;
using Code.Gameplay.StaticData;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Identifiers;
using Code.Infrastructure.Loading;
using Code.Infrastructure.States.Factory;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Infrastructure.View;
using Code.Progress.Provider;
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
      BindCameraProvider();
      BindProgressServices();
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
	    Container.BindInterfacesAndSelfTo<HomeScreenState>().AsSingle();
	    Container.BindInterfacesAndSelfTo<LoadingBattleState>().AsSingle();
	    Container.BindInterfacesAndSelfTo<BattleEnterState>().AsSingle();
	    Container.BindInterfacesAndSelfTo<BattleLoopState>().AsSingle();
    }

		private void BindContexts()
    {
      Container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();
      
      Container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
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
      Container.Bind<ILevelDataProvider>().To<LevelDataProvider>().AsSingle();
    }

		private void BindGameplayFactories()
		{
			Container.Bind<IEntityViewFactory>().To<EntityViewFactory>().AsSingle();
			Container.Bind<IHeroFactory>().To<HeroFactory>().AsSingle();
			Container.Bind<IEnemyFactory>().To<EnemyFactory>().AsSingle();
			Container.Bind<IArmamentFactory>().To<ArmamentFactory>().AsSingle();
			Container.Bind<IAbilityFactory>().To<AbilityFactory>().AsSingle();
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
    
    public void Initialize()
    {
			Container.Resolve<IGameStateMachine>().Enter<BootstrapState>();
		}
  }
}