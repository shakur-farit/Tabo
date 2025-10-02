using System;

namespace Code.Gameplay.Features.Music
{
  public interface IMusicVolumeService
  {
    event Action MusicVolumeChanged;
    void RaiseMusicVolume();
    void LowMusicVolume();
    float GetMusicVolume(float configVolume);
    float GetMusicVolumeIndicator();
  }
}