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
  public class SettingsWindow : BaseWindow
  {
    [SerializeField] private Button _backButton;
    [SerializeField] private Button _musicRaiseButton;
    [SerializeField] private Button _musicLowButton;
    [SerializeField] private Button _specialEffectRaiseButton;
    [SerializeField] private Button _specialEffectLowButton;
    [SerializeField] private TextMeshProUGUI _musicVolumeText;
    [SerializeField] private TextMeshProUGUI _musicSoundEffectsText;

    private IWindowService _windowService;
    private IMusicVolumeService _musicVolumeService;

    [Inject]
    public void Constructor(IWindowService windowService, IMusicVolumeService musicVolumeService)
    {
      Id = WindowId.SettingsWindow;

      _windowService = windowService;
      _musicVolumeService = musicVolumeService;
    }

    protected override void Initialize()
    {
      _backButton.onClick.AddListener(Close);

      _musicRaiseButton.onClick.AddListener(RaiseMusicVolume);
      _musicLowButton.onClick.AddListener(LowMusicVolume);

      UpdateMusicVolumeText();
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
  }
}