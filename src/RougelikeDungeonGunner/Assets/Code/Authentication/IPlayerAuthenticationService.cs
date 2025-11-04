using Cysharp.Threading.Tasks;

namespace Code.Meta
{
  public interface IPlayerAuthenticationService
  {
    bool IsAuthenticated { get; }
    string PlayerId { get; }
    string PlayerName { get; }
    UniTask Initialize();
    UniTask SignIn();
    UniTask SetPlayerName(string name);
  }
}