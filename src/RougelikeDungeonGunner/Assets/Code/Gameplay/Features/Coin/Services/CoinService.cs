using System;
using Code.Progress.Data.Progress;

namespace Code.Gameplay.Features.Hero.Services
{
  public class CoinService : ICoinService
  {
    public event Action CoinCountChanged;

    private int _currentCoinsCount;

    public int GetCurrentCoinCount() => 
      _currentCoinsCount;

    public void SetCurrentCoinCount(int value)
    {
      int clampedValue = Math.Max(0, value);

      if (_currentCoinsCount == clampedValue)
        return;

      _currentCoinsCount = clampedValue;

      CoinCountChanged?.Invoke();
    }
  }
}