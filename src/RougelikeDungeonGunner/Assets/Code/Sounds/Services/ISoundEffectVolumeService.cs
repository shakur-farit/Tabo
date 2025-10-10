namespace Code.Sounds.Services
{
  public interface ISoundEffectVolumeService
  {
    void RaiseSoundEffectVolume();
    void LowSoundEffectVolume();
    float GetSoundEffectVolume(float configVolume);
    float GetSoundEffectVolumeIndicator();
  }
}