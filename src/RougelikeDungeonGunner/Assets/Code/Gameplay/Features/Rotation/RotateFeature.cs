using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Movement
{
	public sealed class RotateFeature : Feature
	{
		public RotateFeature(ISystemsFactory systems)
		{
			Add(systems.Create<RotateAlongDirectionSystem>());
		}
	}
}