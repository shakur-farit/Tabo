using System;

namespace Code.Gameplay.Features.Coin.Services
{
  public interface ICoinService
  {
    event Action CoinCountChanged;
    int GetCurrentCoinCount();
    void SetCurrentCoinCount(int value);
  }
}