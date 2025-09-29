using Code.Gameplay.Features.Music.Configs;
using Code.Gameplay.StaticData;
using UnityEngine;

namespace Code.Gameplay.Features.Music
{
	public class MusicProvider : IMusicSourceSetter, IMusicClipSetter
	{
		private AudioSource _audioSource;

		private readonly IStaticDataService _staticDataService;

		public MusicProvider(IStaticDataService staticDataService) => 
			_staticDataService = staticDataService;

		public void SetMusicSource(AudioSource audioSource) => 
			_audioSource = audioSource;

		public void SetClip(MusicTypeId typeId)
		{
			MusicConfig config = _staticDataService.GetMusicConfig(typeId);

			_audioSource.clip = config.AudioClip;
			_audioSource.Play();
			_audioSource.volume = config.Volume;
		}
	}
}