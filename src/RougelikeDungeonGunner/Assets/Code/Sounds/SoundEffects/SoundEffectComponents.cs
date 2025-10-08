using Entitas;
using UnityEngine;

namespace Code.Sounds.SoundEffects
{
	[Game] public class SoundEffect : IComponent { }
	[Game] public class SoundEffectTypeIdComponent : IComponent { public SoundEffectTypeId Value; }
	[Game] public class AudioSourceComponent : IComponent { public AudioSource Value; }
	[Game] public class AudioClipComponent : IComponent { public AudioClip Value; }
	[Game] public class Volume : IComponent { public float Value; }

}