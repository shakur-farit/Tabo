using Cysharp.Threading.Tasks;

namespace Code.Meta
{
  public interface ILeaderboardGetter
  {
    UniTask GetLeaderboard();
  }
}