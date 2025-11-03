using Cysharp.Threading.Tasks;

namespace Code.Meta
{
  public interface ILeaderboardInitializer
  {
    UniTask Initialize();
  }
}