using Code.Infrastructure;

namespace Code.Gameplay.Features.Lifetime
{
	public sealed class DeathFeature : Feature
	{
		public DeathFeature(ISystemsFactory systems)
		{
			Add(systems.Create<MarkDeadSystem>());
		}
	}
}