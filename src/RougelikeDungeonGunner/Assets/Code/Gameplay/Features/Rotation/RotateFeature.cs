using Assets.Code.Gameplay.Features.Rotation.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.Rotation
{
	public sealed class RotateFeature : Feature
	{
		public RotateFeature(ISystemsFactory systems)
		{
			Add(systems.Create<RotateAlongDirectionSystem>());
		}
	}
}