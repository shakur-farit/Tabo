using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Music
{
  public class SoundEffectFactory : ISoundEffectFactory
  {
    private readonly IStaticDataService _staticDataService;
    private readonly ISoundEffectVolumeService _volumeService;

    public SoundEffectFactory(IStaticDataService staticDataService, ISoundEffectVolumeService volumeService)
    {
      _staticDataService = staticDataService;
      _volumeService = volumeService;
    }

    public SoundsEntity CreateSoundEffect(SoundEffectsTypeId typeId)
    {
      SoundEffectConfig config = _staticDataService.GetSoundEffectConfig(typeId);
      float volume = _volumeService.GetSoundEffectVolume(config.Volume);

      return CreateSoundsEntity.Empty()
          .AddSoundEffectsTypeId(typeId)
          .AddVolume(volume)
          .AddSelfDestructedTimer(1f)
          .With(x => x.isSoundEffects = true)
        ;
    }
  }
}