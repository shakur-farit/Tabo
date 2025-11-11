using System.Collections.Generic;
using Code.Meta.UI.GameLoading.Services;
using Entitas;

namespace Code.Meta.UI.GameLoading.Systems
{
  public class CloseLoadingUISystem : IExecuteSystem
  {
    private readonly List<MetaEntity> _buffer = new(1);

    private readonly IGameLoadingUIService _gameLoadingUIService;
    private readonly IGroup<MetaEntity> _loadingUIs;

    public CloseLoadingUISystem(MetaContext meta, IGameLoadingUIService gameLoadingUIService)
    {
      _gameLoadingUIService = gameLoadingUIService;
      _loadingUIs = meta.GetGroup(MetaMatcher
        .AllOf(
          MetaMatcher.LoadingUIOpen));
    }

    public void Execute()
    {
      foreach (MetaEntity loadingUIs in _loadingUIs.GetEntities(_buffer))
      {
        _gameLoadingUIService.Close();
        loadingUIs.isLoadingUIOpen = false;
        loadingUIs.isDestructed = true;
      }
    }
  }
}