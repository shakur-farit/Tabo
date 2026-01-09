using TMPro;
using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours.MainMenu
{
  public class MobileKeyboard : MonoBehaviour
  {
    [SerializeField] private TMP_InputField _inputField;

    private void Awake() => 
      gameObject.SetActive(false);

    public void AddChar(string character)
    {
      if (_inputField == null)
        return;

      _inputField.text += character;
      _inputField.caretPosition = _inputField.text.Length;
    }

    public void Backspace()
    {
      if (_inputField == null || _inputField.text.Length == 0)
        return;

      _inputField.text = _inputField.text.Substring(0, _inputField.text.Length - 1);
      _inputField.caretPosition = _inputField.text.Length;
    }

    public void HideKeyboard() => 
      gameObject.SetActive(false);
  }
}