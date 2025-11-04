namespace Code.Meta.UI.Windows.Service
{
  public interface IDialogueService
  {
    string GetDialogueText();
    void OpenNotEnoughCoinsDialogue();
    void OpenAppliedEnchantDialogue();
    void OpenMaxValueDialogue();
  }
}