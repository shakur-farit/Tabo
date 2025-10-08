using System;

namespace Code.Gameplay.Features.Hero
{
  public interface ICoinService
  {
    event Action CoinCountChanged;
    int GetCurrentCoinCount();
    void SetCurrentCoinCount(int value);
  }
}