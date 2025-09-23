using Code.Common.Destruct;
using Code.Infrastructure.Systems;

namespace Code.Meta
{
	public sealed class HomeScreenFeature : Feature
	{
		public HomeScreenFeature(ISystemsFactory systems)
		{
			Add(systems.Create<ProcessMetaDestructedFeature>());
		}
	}
}