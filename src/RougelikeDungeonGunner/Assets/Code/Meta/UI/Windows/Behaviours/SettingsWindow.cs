using Code.Gameplay.Common.Time;
using Code.Infrastructure.Services;
using Code.Meta.UI.Windows.Service;
using Code.Sounds.Services;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class SettingsWindow : BaseWindow
  {
    [SerializeField] private Button _backButton;
    [SerializeField] private Button _musicRaiseButton;
    [SerializeField] private Button _musicLowButton;
    [SerializeField] private Button _soundEffectRaiseButton;
    [SerializeField] private Button _soundEffectLowButton;
    [SerializeField] private TextMeshProUGUI _musicVolumeText;
    [SerializeField] private TextMeshProUGUI _soundEffectVolumeText;

    private IWindowService _windowService;
    private IMusicVolumeService _musicVolumeService;
    private ISoundEffectVolumeService _soundEffectVolumeService;

    [Inject]
    public void Constructor(
	    IWindowService windowService, 
	    IMusicVolumeService musicVolumeService,
	    ISoundEffectVolumeService soundEffectVolumeService)
    {
      Id = WindowId.SettingsWindow;

      _windowService = windowService;
      _musicVolumeService = musicVolumeService;
      _soundEffectVolumeService = soundEffectVolumeService;
    }

    protected override void Initialize()
    {
      _backButton.onClick.AddListener(Close);

      _musicRaiseButton.onClick.AddListener(RaiseMusicVolume);
      _musicLowButton.onClick.AddListener(LowMusicVolume);
      _soundEffectRaiseButton.onClick.AddListener(RaiseSoundEffectVolume);
      _soundEffectLowButton.onClick.AddListener(LowSoundEffectVolume);

      UpdateMusicVolumeText();
      UpdateSoundEffectVolumeText();
    }

    private void Close() =>
      _windowService.Close(WindowId.SettingsWindow);

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

    private void RaiseSoundEffectVolume()
    {
      _soundEffectVolumeService.RaiseSoundEffectVolume();
			UpdateSoundEffectVolumeText();
		}

		private void LowSoundEffectVolume()
    {
      _soundEffectVolumeService.LowSoundEffectVolume();
	    UpdateSoundEffectVolumeText();
    }

    private void UpdateSoundEffectVolumeText() =>
	    _soundEffectVolumeText.text = _soundEffectVolumeService.GetSoundEffectVolumeIndicator().ToString();
	}
}