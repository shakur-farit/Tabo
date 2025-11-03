using Cysharp.Threading.Tasks;

namespace Code.Meta
{
  public interface ILeaderboardUpdater
  {
    UniTask UpdateLeaderboard();
  }
}