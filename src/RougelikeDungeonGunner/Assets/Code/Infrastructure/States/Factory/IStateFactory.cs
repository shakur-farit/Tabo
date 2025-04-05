using Code.Infrastructure.States.StateInfrastructure;

namespace Code.Infrastructure.States.Factory
{
	public interface IStateFactory
	{
		T GetGameState<T>() where T : class, IExitableState;
	}
}