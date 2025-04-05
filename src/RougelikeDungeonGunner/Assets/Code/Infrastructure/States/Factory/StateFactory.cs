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
	}
}