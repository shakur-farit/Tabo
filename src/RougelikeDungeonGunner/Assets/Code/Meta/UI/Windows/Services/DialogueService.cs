using Code.Gameplay.StaticData;

namespace Code.Meta.UI.Windows.Service
{
  public class DialogueService : IDialogueService
  {
    private string _dialogueText;

    private readonly IWindowService _windowService;
    private readonly IStaticDataService _staticDataService;

    public DialogueService(IWindowService windowService, IStaticDataService staticDataService)
    {
      _windowService = windowService;
      _staticDataService = staticDataService;
    }

    public string GetDialogueText() => 
      _dialogueText;

    public void OpenNotEnoughCoinsDialogue()
    {
      _dialogueText = _staticDataService.GetDialogueConfig().NotEnoughCoins;
      _windowService.Open(WindowId.DialogueWindow);
    }

    public void OpenAppliedEnchantDialogue()
    {
      _dialogueText = _staticDataService.GetDialogueConfig().AppliedEnchant;
      _windowService.Open(WindowId.DialogueWindow);
    }

    public void OpenMaxValueDialogue()
    {
      _dialogueText = _staticDataService.GetDialogueConfig().MaxValue;
      _windowService.Open(WindowId.DialogueWindow);
    }
  }
}