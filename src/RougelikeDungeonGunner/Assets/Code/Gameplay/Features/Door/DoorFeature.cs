using Code.Gameplay.Features.Level.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Weapon
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