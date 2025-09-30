using System;
using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Music
{
  public class SoundsVolumeService : IMusicVolumeService
  {
    public const float MinVolumeIndicator = 0f;
    public const float MaxVolumeIndicator = 100f;
    public const float VolumeIndicatorStep = 10f;

    public event Action MusicVolumeChanged;

    private float _currentMusicVolumeIndicator = 50f;
    private float _currentSpecialEffectsVolumeIndicator;

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

    public void RaiseSpecialEffectsVolume()
    {
      _currentSpecialEffectsVolumeIndicator += VolumeIndicatorStep;

      if (_currentSpecialEffectsVolumeIndicator > MaxVolumeIndicator)
        _currentSpecialEffectsVolumeIndicator = MaxVolumeIndicator;
    }

    public void LowSpecialEffectsVolume()
    {
      _currentSpecialEffectsVolumeIndicator -= VolumeIndicatorStep;

      if (_currentSpecialEffectsVolumeIndicator < MinVolumeIndicator)
        _currentSpecialEffectsVolumeIndicator = MinVolumeIndicator;
    }

    public float GetSpecialEffectsVolume(MusicTypeId typeId)
    {
      var config = _staticDataService.GetMusicConfig(typeId);
      float volume = config.Volume;
      volume = volume / 100 * _currentSpecialEffectsVolumeIndicator;
      return volume;
    }
  }
}