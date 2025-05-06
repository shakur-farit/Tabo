using Code.Common;
using Code.Infrastructure;

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