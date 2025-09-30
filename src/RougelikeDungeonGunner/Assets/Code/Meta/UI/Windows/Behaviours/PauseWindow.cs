using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Music;
using Code.Infrastructure.Services;
using Code.Meta.UI.Windows.Service;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class PauseWindow : BaseWindow
  {
    [SerializeField] private Button _unpauseButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private Button _musicRaiseButton;
    [SerializeField] private Button _musicLowButton;
    [SerializeField] private Button _specialEffectRaiseButton;
    [SerializeField] private Button _specialEffectLowButton;
    [SerializeField] private TextMeshProUGUI _musicVolumeText;
    [SerializeField] private TextMeshProUGUI _musicSoundEffectsText;

    private IWindowService _windowService;
    private ITimeService _time;
    private IQuitGameService _quit;
    private IMusicVolumeService _musicVolumeService;

    [Inject]
    public void Constructor(
      IWindowService windowService, 
      ITimeService time, 
      IQuitGameService quit,
      IMusicVolumeService musicVolumeService)
    {
      Id = WindowId.PauseWindow;

      _windowService = windowService;
      _time = time;
      _quit = quit;
      _musicVolumeService = musicVolumeService;
    }

    protected override void Initialize()
    {
      _unpauseButton.onClick.AddListener(Unpause);
      _quitButton.onClick.AddListener(Quit);

      _musicRaiseButton.onClick.AddListener(RaiseMusicVolume);
      _musicLowButton.onClick.AddListener(LowMusicVolume);

      UpdateMusicVolumeText();
    }

    private void Quit()
    {
      Close();

      _quit.QuitGame();
    }

    private void Unpause()
    {
      Close();

      _time.StartTime();
    }

    private void Close() =>
      _windowService.Close(WindowId.PauseWindow);

    private void RaiseMusicVolume()
    {
      _musicVolumeService.RaiseMusicVolume();

      UpdateMusicVolumeText();
    }

    private void LowMusicVolume()
    {
      _musicVolumeService.LowMusicVolume();

      UpdateMusicVolumeText();
    }

    private void UpdateMusicVolumeText() => 
      _musicVolumeText.text = _musicVolumeService.GetMusicVolumeIndicator().ToString();
  }
}