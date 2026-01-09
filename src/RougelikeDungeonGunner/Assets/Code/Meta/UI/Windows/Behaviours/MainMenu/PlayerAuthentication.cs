using Code.Authentication;
using Code.Progress.Provider;
using Code.Progress.SaveLoad;
using Cysharp.Threading.Tasks;
using System.Text.RegularExpressions;
using Code.Meta.UI.Windows.Services;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.MainMenu
{
  public class PlayerAuthentication : MonoBehaviour
  {
    [SerializeField] private TMP_InputField _inputField;

    private readonly Regex _validNameRegex = new(@"^[a-zA-Z0-9_]*$");

    private IProgressProvider _progressProvider;
    private ISaveSystem _saveSystem;
    private IPlayerAuthenticationService _authService;
    private IDialogueService _dialogueService;

    [Inject]
    public void Constructor(
      IProgressProvider progressProvider,
      ISaveSystem saveSystem,
      IPlayerAuthenticationService authService,
      IDialogueService dialogueService)
    {
      _progressProvider = progressProvider;
      _saveSystem = saveSystem;
      _authService = authService;
      _dialogueService = dialogueService;
    }

    private void Awake() => 
      _inputField.onValueChanged.AddListener(FilterInput);

    private void Start() => 
      UseLastUsedName();

    public async UniTask<bool> IsNameValid()
    {
      string playerName = _inputField.text.Trim();

      if (string.IsNullOrEmpty(playerName))
      {
        _dialogueService.OpenInEmptyName();
        return false;
      }

      if (playerName.Length > 10)
      {
        _dialogueService.OpenLongName();
        return false;
      }

      if (playerName.Length < 2)
      {
        _dialogueService.ShortName();
        return false;
      }

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

    private void FilterInput(string input)
    {
      if (_validNameRegex.IsMatch(input) == false) 
        _inputField.text = Regex.Replace(input, @"[^a-zA-Z0-9_]", "");
    }
  }
}