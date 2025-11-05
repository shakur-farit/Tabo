using Cysharp.Threading.Tasks;

namespace Code.Leaderboard
{
  public interface ILeaderboardUpdater
  {
    UniTask UpdateLeaderboard();
  }
}