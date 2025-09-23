using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Input
{
	public sealed class PauseFeature : Feature
	{
		public PauseFeature(ISystemsFactory systems)
		{
			Add(systems.Create<TogglePauseReactiveSystem>());
		}
	}
}