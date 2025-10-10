using Code.Sounds.Music.Services;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
	public class MusicInitializer : MonoBehaviour, IInitializable
	{
		public AudioSource AudioSource;

		private IMusicSourceSetter _musicSourceSetter;

		[Inject]
		public void Constructor(IMusicSourceSetter musicSourceSetter) => 
			_musicSourceSetter = musicSourceSetter;

		public void Initialize() => 
			_musicSourceSetter.SetMusicSource(AudioSource);
	}
}