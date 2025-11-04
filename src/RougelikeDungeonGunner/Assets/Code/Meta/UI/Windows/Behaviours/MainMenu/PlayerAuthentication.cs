using Code.Gameplay.StaticData;
using Code.Progress.Data.Progress;
using Code.Progress.Provider;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class PlayerAuthentication : MonoBehaviour
  {
    [SerializeField] private TMP_InputField _inputField;

    private IProgressProvider _progressProvider;
    private ISaveSystem _saveSystem;
    private IPlayerAuthenticationService _authService;

    [Inject]
    public void Constructor(
      IProgressProvider progressProvider,
      ISaveSystem saveSystem,
      IPlayerAuthenticationService authService)
    {
      _progressProvider = progressProvider;
      _saveSystem = saveSystem;
      _authService = authService;
    }

    private void Start() => 
      UseLastUsedName();

    public async UniTask<bool> IsNameValid()
    {
      string playerName = _inputField.text.Trim();

      if (string.IsNullOrEmpty(playerName) || playerName.Length > 10)
        return false;

      _progressProvider.ProgressData.PlayerData.Name = playerName;
      _saveSystem.Save();

      await _authService.SetPlayerName(playerName);

      return true;
    }

    private void UseLastUsedName()
    {
      if(_progressProvider.ProgressData.PlayerData == null)
        return;

      _inputField.text = _progressProvider.ProgressData.PlayerData.Name;
    }
  }
}