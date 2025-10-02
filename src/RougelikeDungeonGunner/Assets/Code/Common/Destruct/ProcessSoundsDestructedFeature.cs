using Code.Common.Destruct.Systems;
using Code.Infrastructure.Systems;

namespace Code.Common.Destruct
{
  public sealed class ProcessSoundsDestructedFeature : Feature
  {
    public ProcessSoundsDestructedFeature(ISystemsFactory systems)
    {
      Add(systems.Create<CleanupSoundsDestructedSystem>());
    }
  }
}