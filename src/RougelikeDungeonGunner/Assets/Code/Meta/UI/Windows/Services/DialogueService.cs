namespace Code.Meta.UI.Windows.Service
{
  public class DialogueService : IDialogueService
  {
    private string _dialogueText;

    public string GetDialogueText() => 
      _dialogueText;

    public void SetDialogueText(string text) => 
      _dialogueText = text;
  }
}