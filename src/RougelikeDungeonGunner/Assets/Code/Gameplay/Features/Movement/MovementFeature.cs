using Code.Gameplay.Features.Movement.Systems;
using Code.Infrastructure;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Movement
{
	public sealed class MovementFeature : Feature
	{
		public MovementFeature(ISystemsFactory systems)
		{
			Add(systems.Create<DirectionalDeltaMoveSystem>());
			Add(systems.Create<UpdateTransformPositionSystem>());
			Add(systems.Create<UpdateChildrenPositionRelativeParentSystem>());
		}
	}
}