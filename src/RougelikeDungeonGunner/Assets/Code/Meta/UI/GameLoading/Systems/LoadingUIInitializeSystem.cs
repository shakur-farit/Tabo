using Code.Common.Entity;
using Code.Common.Extensions;
using Entitas;

namespace Code.Meta.UI.GameLoading
{
  public class LoadingUIInitializeSystem :IInitializeSystem
  {
    public void Initialize()
    {
      CreateMetaEntity.Empty()
        .With(x => x.isLoadingUIOpen = true);
    }
  }
}