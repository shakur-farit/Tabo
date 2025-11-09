using Code.Infrastructure.Systems;

namespace Code.Meta.UI.GameLoading
{
  public sealed class LoadingUIFeature : Feature
  {
    public LoadingUIFeature(ISystemsFactory systems)
    {
      Add(systems.Create<LoadingUIInitializeSystem>());
   
      Add(systems.Create<CloseLoadingUISystem>());
    }
  }
}