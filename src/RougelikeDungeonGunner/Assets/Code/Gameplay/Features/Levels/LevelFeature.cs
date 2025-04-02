using Code.Infrastructure;

namespace Code.Gameplay.Features.Levels
{
	public sealed class LevelFeature : Feature
	{
		public LevelFeature(ISystemsFactory systems)
		{
			Add(systems.Create<EnemyWaveSystem>());
		}
	}
}