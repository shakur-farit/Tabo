using Cysharp.Threading.Tasks;

namespace Code.Leaderboard
{
  public interface ILeaderboardInitializer
  {
    UniTask Initialize();
  }
}