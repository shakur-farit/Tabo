namespace Code.Infrastructure.View
{
	public sealed class BindViewFeature : Feature
	{
		public BindViewFeature(ISystemsFactory systems)
		{
			Add(systems.Create<BindEntityViewFromPathSystem>());
			Add(systems.Create<BindEntityViewFromPrefabSystem>());
			Add(systems.Create<SetParentForEntityViewSystem>());
			Add(systems.Create<UnparentEntityViewSystem>());
		}
	}
}