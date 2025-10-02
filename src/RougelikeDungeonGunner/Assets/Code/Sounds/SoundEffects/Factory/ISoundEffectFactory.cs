namespace Code.Gameplay.Features.Music
{
  public interface ISoundEffectFactory
  {
    SoundsEntity CreateSoundEffect(SoundEffectsTypeId typeId);
  }
}