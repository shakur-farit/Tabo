namespace Code.Sounds.SoundEffects.Factory
{
  public interface ISoundEffectFactory
  {
    GameEntity CreateSoundEffect(SoundEffectTypeId typeId);
  }
}