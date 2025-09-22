using Assets.Code.Common.Destruct;
using Assets.Code.Infrastructure.Systems;
using Code.Common;

namespace Assets.Code.Meta
{
	public sealed class HomeScreenFeature : Feature
	{
		public HomeScreenFeature(ISystemsFactory systems)
		{
			Add(systems.Create<ProcessMetaDestructedFeature>());
		}
	}
}