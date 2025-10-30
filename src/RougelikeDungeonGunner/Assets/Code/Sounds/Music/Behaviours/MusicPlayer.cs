using Code.Sounds.Music;
using Code.Sounds.Music.Services;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class MusicPlayer : MonoBehaviour
	{
		[SerializeField] private MusicTypeId _music;

		private IMusicClipSetter _clipSetter;

		[Inject]
		public void Constructor(IMusicClipSetter clipSetter) => 
			_clipSetter = clipSetter;

		private void Start() => 
			PlayMusic();

		private void PlayMusic() =>
			_clipSetter.SetClip(_music);

	}
}