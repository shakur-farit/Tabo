using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Music
{
	[Sounds] public class SoundEffects : IComponent { }
	[Sounds] public class SoundEffectsTypeIdComponent : IComponent { public SoundEffectsTypeId Value; }
	[Sounds] public class AudioSourceComponent : IComponent { public AudioSource Value; }
	[Sounds] public class Volume : IComponent { public float Value; }

}