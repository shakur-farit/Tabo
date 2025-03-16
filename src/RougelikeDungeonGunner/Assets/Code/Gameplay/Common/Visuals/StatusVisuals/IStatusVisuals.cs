using Entitas;

namespace Code.Gameplay.Common
{
	public interface IStatusVisuals
	{
		void ApplyFreeze();
		void UnapplyFreeze();
		void ApplyPoison();
		void UnapplyPoison();
	}
}