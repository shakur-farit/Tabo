using Code.Gameplay.Features.CharacterStats.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.CharacterStats
{
	public sealed class StatsFeature : Feature
	{
		public StatsFeature(ISystemsFactory systems)
		{
			Add(systems.Create<StatChangeSystem>());

			Add(systems.Create<ApplySpeedFromStatsSystem>());
		}
	}
}