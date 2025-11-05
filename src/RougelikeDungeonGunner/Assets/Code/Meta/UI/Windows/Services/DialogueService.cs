using Code.Gameplay.StaticData;

namespace Code.Meta.UI.Windows.Services
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

    public void OpenNotEnoughCoinsDialogue() => 
      OpenDialogue(_staticDataService.GetDialogueConfig().NotEnoughCoins);

    public void OpenAppliedEnchantDialogue() => 
      OpenDialogue(_staticDataService.GetDialogueConfig().AppliedEnchant);

    public void OpenMaxValueDialogue() => 
      OpenDialogue(_staticDataService.GetDialogueConfig().MaxValue);

    public void OpenInEmptyName() => 
      OpenDialogue(_staticDataService.GetDialogueConfig().EmptyNameField);

    public void OpenLongName() => 
      OpenDialogue(_staticDataService.GetDialogueConfig().LongName);

    public void ShortName() => 
      OpenDialogue(_staticDataService.GetDialogueConfig().ShortName);

    private void OpenDialogue(string message)
    {
      _dialogueText = message;
      _windowService.Open(WindowId.DialogueWindow);
    }
  }
}