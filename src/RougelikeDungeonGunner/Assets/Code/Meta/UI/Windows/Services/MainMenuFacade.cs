using Code.Infrastructure.Loading;
using Code.Infrastructure.Services;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.Features.HeroSelector.Factory;
using Code.Meta.UI.Windows.Service;
using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class MainMenuFacade : IMainMenuFacade
  {
    private readonly IGameStateMachine _stateMachine;
    private readonly IWindowService _windowService;
    private readonly IQuitGameService _quit;
    private readonly IHeroSelectorFactory _heroSelectorFactory;

    public MainMenuFacade(
      IGameStateMachine stateMachine, 
      IWindowService windowService, 
      IQuitGameService quit, 
      IHeroSelectorFactory heroSelectorFactory)
    {
      _stateMachine = stateMachine;
      _windowService = windowService;
      _quit = quit;
      _heroSelectorFactory = heroSelectorFactory;
    }

    public void StartGame()
    {
      Object.Destroy(_heroSelectorFactory.HeroSelector);
      _stateMachine.Enter<LoadingBattleState, string>(Scenes.Gameplay);
      _windowService.Close(WindowId.MainMenuWindow);
    }

    public void OpenSettings() => _windowService.Open(WindowId.SettingsWindow);

    public void QuitGame()
    {
      _windowService.Close(WindowId.MainMenuWindow);
      _quit.QuitGame();
    }
  }
}