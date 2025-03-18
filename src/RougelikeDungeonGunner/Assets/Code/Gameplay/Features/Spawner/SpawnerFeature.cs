using Code.Gameplay.Features.Spawner.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.Spawner
{
	public sealed class SpawnerFeature : Feature
	{
		public SpawnerFeature(ISystemsFactory systems)
		{
			Add(systems.Create<SpawnEnemiesSystem>());
		}
	}
}