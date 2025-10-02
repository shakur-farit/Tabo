using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Music
{
  public class AudioSourceRegistrar : EntityComponentRegistrar
  {
    [SerializeField] private AudioSource _audioSource;

    public override void RegisterComponents() =>
      Entity.AddAudioSource(_audioSource);

    public override void UnregisterComponents()
    {
      if (Entity.hasAudioSource)
        Entity.RemoveAudioSource();
    }
  }
}