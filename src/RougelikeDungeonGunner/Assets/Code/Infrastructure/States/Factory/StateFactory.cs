using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Hero.States;
using Code.Infrastructure.States.StateInfrastructure;
using Zenject;

namespace Code.Infrastructure.States.Factory
{
	public class StateFactory : IStateFactory
	{
		private readonly DiContainer _container;

		public StateFactory(DiContainer container) => 
			_container = container;

		public T GetGameState<T>() where T : class, IExitableState => 
			_container.Resolve<T>();

		public T GetHeroAnimationState<T>() where T : class, IHeroAnimationState =>
			_container.Resolve<T>();

		public T GetEnemyAnimationState<T>() where T : class, IEnemyAnimationState => 
			_container.Resolve<T>();
	}
}