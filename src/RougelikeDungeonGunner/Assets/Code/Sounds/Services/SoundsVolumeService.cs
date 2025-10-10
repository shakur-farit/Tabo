using System;
using Code.Gameplay.StaticData;

namespace Code.Sounds.Services
{
  public class SoundsVolumeService : IMusicVolumeService, ISoundEffectVolumeService
  {
    public const float MinVolumeIndicator = 0f;
    public const float MaxVolumeIndicator = 100f;
    public const float VolumeIndicatorStep = 10f;

    public event Action MusicVolumeChanged;

    private float _currentMusicVolumeIndicator = 50f;
    private float _currentSoundEffectVolumeIndicator = 50f;

    private readonly IStaticDataService _staticDataService;


    public SoundsVolumeService(IStaticDataService staticDataService) => 
      _staticDataService = staticDataService;

    public void RaiseMusicVolume()
    {
      _currentMusicVolumeIndicator += VolumeIndicatorStep;

      if (_currentMusicVolumeIndicator > MaxVolumeIndicator)
        _currentMusicVolumeIndicator = MaxVolumeIndicator;

      MusicVolumeChanged?.Invoke();
    }

    public void LowMusicVolume()
    {
      _currentMusicVolumeIndicator -= VolumeIndicatorStep;

      if (_currentMusicVolumeIndicator < MinVolumeIndicator)
        _currentMusicVolumeIndicator = MinVolumeIndicator;

      MusicVolumeChanged?.Invoke();
    }

    public float GetMusicVolume(float configVolume) => 
      configVolume / 100 * _currentMusicVolumeIndicator;

    public float GetMusicVolumeIndicator() => 
      _currentMusicVolumeIndicator;

    public void RaiseSoundEffectVolume()
    {
      _currentSoundEffectVolumeIndicator += VolumeIndicatorStep;

      if (_currentSoundEffectVolumeIndicator > MaxVolumeIndicator)
        _currentSoundEffectVolumeIndicator = MaxVolumeIndicator;
    }

    public void LowSoundEffectVolume()
    {
      _currentSoundEffectVolumeIndicator -= VolumeIndicatorStep;

      if (_currentSoundEffectVolumeIndicator < MinVolumeIndicator)
        _currentSoundEffectVolumeIndicator = MinVolumeIndicator;
    }

    public float GetSoundEffectVolume(float configVolume) => 
      configVolume / 100 * _currentSoundEffectVolumeIndicator;

    public float GetSoundEffectVolumeIndicator() => 
      _currentSoundEffectVolumeIndicator;
  }
}