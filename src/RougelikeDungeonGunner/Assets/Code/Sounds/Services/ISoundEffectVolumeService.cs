namespace Code.Gameplay.Features.Music
{
  public interface ISoundEffectVolumeService
  {
    void RaiseSoundEffectVolume();
    void LowSoundEffectVolume();
    float GetSoundEffectVolume(float configVolume);
    float GetSoundEffectVolumeIndicator();
  }
}