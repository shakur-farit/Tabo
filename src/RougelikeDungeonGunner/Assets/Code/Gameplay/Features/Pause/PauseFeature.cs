using Code.Gameplay.Features.Pause.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Pause
{
	public sealed class PauseFeature : Feature
	{
		public PauseFeature(ISystemsFactory systems)
		{
			Add(systems.Create<TogglePauseReactiveSystem>());
		}
	}
}