using UnityEngine;

namespace Code.Sounds.SoundEffects.Systems
{
	public interface ISoundEffectPitchCalculator
	{
		float CalculatePitch(float time, AudioClip clip);
	}
}