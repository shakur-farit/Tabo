using Code.Gameplay.Features.Rotation.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Rotation
{
	public sealed class RotateFeature : Feature
	{
		public RotateFeature(ISystemsFactory systems)
		{
			Add(systems.Create<RotateAlongDirectionSystem>());
		}
	}
}