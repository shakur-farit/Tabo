using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using Code.Sounds.Services;
using Code.Sounds.SoundEffects.Config;

namespace Code.Sounds.SoundEffects.Factory
{
	public class SoundEffectFactory : ISoundEffectFactory
	{
		private readonly IStaticDataService _staticDataService;
		private readonly ISoundEffectVolumeService _volumeService;
		private readonly IIdentifierService _identifier;

		public SoundEffectFactory(
			IStaticDataService staticDataService,
			ISoundEffectVolumeService volumeService,
			IIdentifierService identifier)
		{
			_staticDataService = staticDataService;
			_volumeService = volumeService;
			_identifier = identifier;
		}

		public GameEntity CreateSoundEffect(SoundEffectTypeId typeId)
		{
			SoundEffectConfig config = _staticDataService.GetSoundEffectConfig(typeId);
			float volume = _volumeService.GetSoundEffectVolume(config.Volume);

			return CreateGameEntity.Empty()
					.AddId(_identifier.Next())
					.AddViewPrefab(config.ViewPrefab)
					.AddSoundEffectTypeId(typeId)
					.AddVolume(volume)
					.AddAudioClip(config.AudioClip)
					.AddSelfDestructedTimer(config.Lifetime)
					.With(x => x.isSoundEffect = true)
					.With(x => x.isReusable = true)
				;
		}
	}
}