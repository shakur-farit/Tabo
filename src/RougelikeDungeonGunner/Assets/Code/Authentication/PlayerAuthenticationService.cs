using Code.Progress.Data.Progress;
using Code.Progress.Provider;
using Cysharp.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;

namespace Code.Meta
{
  public class PlayerAuthenticationService : IPlayerAuthenticationService
  {
    private readonly IProgressProvider _progressProvider;
    private readonly ISaveSystem _saveSystem;

    public bool IsAuthenticated => AuthenticationService.Instance?.IsSignedIn ?? false;
    public string PlayerId => AuthenticationService.Instance?.PlayerId;
    public string PlayerName => _progressProvider.ProgressData.PlayerData.Name;

    public PlayerAuthenticationService(IProgressProvider progressProvider, ISaveSystem saveSystem)
    {
      _progressProvider = progressProvider;
      _saveSystem = saveSystem;
    }

    public async UniTask Initialize()
    {
      try
      {
        await UnityServices.InitializeAsync();
      }
      catch (System.Exception e)
      {
        Debug.LogError($"UGS init failed: {e.Message}");
      }
    }

    public async UniTask SignIn()
    {
      if (IsAuthenticated)
        return;

      try
      {
        await AuthenticationService.Instance.SignInAnonymouslyAsync();
        Debug.Log($"Signed in! Player ID: {PlayerId}");

        await AuthenticationService.Instance.UpdatePlayerNameAsync(PlayerName);
      }
      catch (System.Exception e)
      {
        Debug.LogError($"Sign-in failed: {e.Message}");
      }
    }

    public async UniTask SetPlayerName(string name)
    {
      _progressProvider.ProgressData.PlayerData.Name = name;
      _saveSystem.Save();

      if (IsAuthenticated)
      {
        try
        {
          await AuthenticationService.Instance.UpdatePlayerNameAsync(name);
        }
        catch (System.Exception e)
        {
          Debug.LogError($"Failed to update UGS name: {e.Message}");
        }
      }

      Debug.Log($"Player name now: {name}");
    }
  }
}