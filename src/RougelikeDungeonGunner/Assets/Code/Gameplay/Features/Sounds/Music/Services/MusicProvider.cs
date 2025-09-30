using Code.Gameplay.Features.Music.Configs;
using Code.Gameplay.StaticData;
using UnityEngine;

namespace Code.Gameplay.Features.Music.Services
{
	public class MusicProvider : IMusicSourceSetter, IMusicClipSetter
	{
		private AudioSource _audioSource;
    private MusicConfig _currentMusicConfig; 

		private readonly IStaticDataService _staticDataService;
    private readonly IMusicVolumeService _volumeService;

    public MusicProvider(IStaticDataService staticDataService, IMusicVolumeService volumeService)
    {
      _staticDataService = staticDataService;
      _volumeService = volumeService;

      volumeService.MusicVolumeChanged += UpdateVolume;
    }

    public void SetMusicSource(AudioSource audioSource) => 
			_audioSource = audioSource;

		public void SetClip(MusicTypeId typeId)
		{
			_currentMusicConfig = _staticDataService.GetMusicConfig(typeId);

			_audioSource.clip = _currentMusicConfig.AudioClip;
			_audioSource.Play();
      _audioSource.volume = _volumeService.GetMusicVolume(_currentMusicConfig.Volume);
    }

    private void UpdateVolume() => 
      _audioSource.volume = _volumeService.GetMusicVolume(_currentMusicConfig.Volume);
  }
}