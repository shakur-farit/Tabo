using System;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Common.Time;
using Cysharp.Threading.Tasks.Triggers;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using Zenject;

namespace Code.Gameplay.Features.Flicker.Behaviours
{
  public class LightFlicker : MonoBehaviour
  {
    [SerializeField] private Light2D _light2D;
    [SerializeField] private float _minLightIntensive;
    [SerializeField] private float _maxLightIntensive;
    [SerializeField] private float _minFlickerTime;
    [SerializeField] private float _maxFlickerTime;

    private float _flickerTime;

    private IRandomService _random;
    private ITimeService _time;

    [Inject]
    public void Constructor(IRandomService random, ITimeService time)
    {
      _random = random;
      _time = time;
    }

    private void Start() => 
      _flickerTime = _random.Range(_minFlickerTime, _maxFlickerTime);

    private void Update()
    {
      RandomizeFlickerTime();

      RandomizeLightIntensity();
    }

    private void RandomizeFlickerTime()
    {
      _flickerTime -= _time.DeltaTime;

      if (_flickerTime < 0f)
        _flickerTime = _random.Range(_minFlickerTime, _maxFlickerTime);
    }

    public void RandomizeLightIntensity() =>
      _light2D.intensity = _random.Range(_minLightIntensive, _maxLightIntensive);
  }
}