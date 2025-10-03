using Code.Common.Destruct;
using Code.Gameplay.Features.Music;
using Code.Infrastructure.Systems;

namespace Code.Meta
{
	public sealed class HomeScreenFeature : Feature
	{
		public HomeScreenFeature(ISystemsFactory systems)
		{
			Add(systems.Create<SoundEffectFeature>());
			Add(systems.Create<ProcessMetaDestructedFeature>());
		}
	}
}