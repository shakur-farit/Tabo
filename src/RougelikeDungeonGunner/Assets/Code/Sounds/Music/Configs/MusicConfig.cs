using UnityEngine;

namespace Code.Sounds.Music.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Music Config", fileName = "MusicConfig")]
	public class MusicConfig : ScriptableObject
	{
		public MusicTypeId TypeId;
		public AudioClip AudioClip;	
		[Range(0f, 1f)] public float Volume;
	}
}