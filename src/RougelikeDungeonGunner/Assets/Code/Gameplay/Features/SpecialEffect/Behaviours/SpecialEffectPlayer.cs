using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.SpecialEffect
{
  public class SpecialEffectPlayer : MonoBehaviour
  {
    [SerializeField] private List<ParticleSystem> _particleSystems;

    private void OnEnable()
    {
      foreach (ParticleSystem particleSystem in _particleSystems)
      {
        particleSystem.Stop();
        particleSystem.Play();
      }
    }
  }
}