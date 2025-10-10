using System;

namespace Code.Sounds.Services
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