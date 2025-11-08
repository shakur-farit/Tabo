using UnityEngine;

namespace Code.Sounds.SoundEffects.Systems
{
	public class SoundEffectPitchCalculator : ISoundEffectPitchCalculator
	{
		public float CalculatePitch(float time, AudioClip clip)
		{
			float audioClipDuration = clip.length;

			return audioClipDuration > 0 ? audioClipDuration / time : 1f;
		}
	}
}