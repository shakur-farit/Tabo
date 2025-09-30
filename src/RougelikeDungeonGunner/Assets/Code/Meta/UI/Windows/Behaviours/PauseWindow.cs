using Code.Gameplay.Common.Time;
using Code.Infrastructure.Services;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class PauseWindow : BaseWindow
  {
    [SerializeField] private Button _unpauseButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private Button _settingsButton;

    private IWindowService _windowService;
    private ITimeService _time;
    private IQuitGameService _quit;

    [Inject]
    public void Constructor(IWindowService windowService, ITimeService time, IQuitGameService quit)
    {
      Id = WindowId.PauseWindow;

      _windowService = windowService;
      _time = time;
      _quit = quit;
    }

    protected override void Initialize()
    {
      _unpauseButton.onClick.AddListener(Unpause);
      _quitButton.onClick.AddListener(Quit);
      _settingsButton.onClick.AddListener(OpenSettingsWindow);
    }

    private void Unpause()
    {
      Close();

      _time.StartTime();
    }

    private void OpenSettingsWindow() =>
      _windowService.Open(WindowId.SettingsWindow);

    private void Quit()
    {
      Close();

      _quit.QuitGame();
    }

    private void Close() =>
      _windowService.Close(WindowId.PauseWindow);
  }
}