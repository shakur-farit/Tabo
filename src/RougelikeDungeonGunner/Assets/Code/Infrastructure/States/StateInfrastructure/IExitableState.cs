using Cysharp.Threading.Tasks;

namespace Assets.Code.Infrastructure.States.StateInfrastructure
{
	public interface IExitableState
	{
		UniTask BeginExit();
		UniTask EndExit();
	}
}