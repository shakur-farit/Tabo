using Code.Common.Destruct;
using Code.Infrastructure.Systems;
using Code.Sounds.SoundEffects;
using Unity.Services.Leaderboards;

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