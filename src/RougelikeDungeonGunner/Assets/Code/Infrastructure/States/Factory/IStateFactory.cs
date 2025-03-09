using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Hero.States;
using Code.Infrastructure.States.StateInfrastructure;

namespace Code.Infrastructure.States.Factory
{
	public interface IStateFactory
	{
		T GetGameState<T>() where T : class, IExitableState;
		T GetHeroAnimationState<T>() where T : class, IHeroAnimationState;
	}
}