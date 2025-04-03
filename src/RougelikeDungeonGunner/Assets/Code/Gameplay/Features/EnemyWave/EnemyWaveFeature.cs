using Code.Infrastructure;

namespace Code.Gameplay.Features.Levels
{
	public sealed class EnemyWaveFeature : Feature
	{
		public EnemyWaveFeature(ISystemsFactory systems)
		{
			Add(systems.Create<FinalizeProcessedWaveSystem>());
		}
	}
}