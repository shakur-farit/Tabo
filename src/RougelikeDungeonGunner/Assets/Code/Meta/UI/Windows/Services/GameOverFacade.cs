using Code.Infrastructure.Services;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows.Service;
using Code.Sounds.Music;
using Code.Sounds.Music.Services;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class GameOverFacade : IGameOverFacade
  {
    private readonly IGameStateMachine _stateMachine;
    private readonly IQuitGameService _quit;
    private readonly IMusicClipSetter _clipSetter;
    private readonly IWindowService _windowService;

    public GameOverFacade(IGameStateMachine stateMachine, IQuitGameService quit, IMusicClipSetter clipSetter, IWindowService windowService)
    {
      _stateMachine = stateMachine;
      _quit = quit;
      _clipSetter = clipSetter;
      _windowService = windowService;
    }

    public void RestartGame()
    {
      _windowService.Close(WindowId.GameOverWindow);
      _stateMachine.Enter<LoadingHomeScreenState>();
    }

    public void QuitGame()
    {
      _windowService.Close(WindowId.GameOverWindow);
      _quit.QuitGame();
    }

    public void PlayMusic() =>
      _clipSetter.SetClip(MusicTypeId.DungeonMelancholy);
  }
}