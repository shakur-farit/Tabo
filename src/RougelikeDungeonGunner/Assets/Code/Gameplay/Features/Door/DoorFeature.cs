using Code.Gameplay.Features.Door.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Door
{
	public sealed class DoorFeature : Feature
	{
		public DoorFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CreateDoorReactiveSystem>());
			Add(systems.Create<OpenDoorOnAllEnemiesDeadSystem>());
			Add(systems.Create<PlayDoorOpeningAnimationReactiveSystem>());
			Add(systems.Create<MarkLevelProcessedOnHeroDetectedSystem>());
		}
	}
}