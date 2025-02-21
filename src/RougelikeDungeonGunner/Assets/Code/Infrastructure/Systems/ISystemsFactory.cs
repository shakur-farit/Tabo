using Entitas;

namespace Code.Infrastructure
{
	public interface ISystemsFactory
	{
		T Create<T>() where T : ISystem;
		T Create<T>(params object[] args) where T : ISystem;
	}
}