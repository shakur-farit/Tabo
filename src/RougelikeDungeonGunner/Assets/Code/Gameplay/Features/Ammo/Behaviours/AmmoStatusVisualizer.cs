using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
  public class AmmoStatusVisualizer : MonoBehaviour
  {
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void OnDisable() => 
      _spriteRenderer.color = Color.white;

    public void Visualize(List<StatusSetup> statusSetups)
    {
      Debug.Log("vis");

      if (statusSetups.Count > 1)
        InitMixedColor();
      else
        InitSingleColor(statusSetups[0]);
    }

    private void InitMixedColor() => 
      _spriteRenderer.color = Color.magenta;

    private void InitSingleColor(StatusSetup setup)
    {
      switch (setup.StatusTypeId)
      {
        case StatusTypeId.Freeze:
          _spriteRenderer.color = Color.cyan;
          break;
        case StatusTypeId.Poison:
          _spriteRenderer.color = Color.green;
          break;
        case StatusTypeId.Flame:
          _spriteRenderer.color = Color.red;
          break;
      }
    }
  }
}