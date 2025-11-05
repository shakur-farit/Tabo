namespace Code.Meta.UI.Windows.Services
{
  public interface IDialogueService
  {
    string GetDialogueText();
    void OpenNotEnoughCoinsDialogue();
    void OpenAppliedEnchantDialogue();
    void OpenMaxValueDialogue();
    void OpenInEmptyName();
    void OpenLongName();
    void ShortName();
  }
}