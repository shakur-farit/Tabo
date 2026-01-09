using TMPro;
using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours.MainMenu
{
  public class MobileKeyboardActivator : MonoBehaviour
  {
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private MobileKeyboard _mobileKeyboard;

    private void Awake() => 
      _inputField.onSelect.AddListener(OnInputSelected);

    private void OnInputSelected(string _)
    {
#if UNITY_WEBGL
      if (Application.isMobilePlatform)
        _mobileKeyboard.gameObject.SetActive(true);
#endif
    }
  }
}