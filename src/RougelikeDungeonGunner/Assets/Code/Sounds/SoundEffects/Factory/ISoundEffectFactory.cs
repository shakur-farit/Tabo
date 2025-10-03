namespace Code.Gameplay.Features.Music
{
  public interface ISoundEffectFactory
  {
    GameEntity CreateSoundEffect(SoundEffectTypeId typeId);
  }
}