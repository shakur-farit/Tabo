using Code.Meta.UI.Windows.Service;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class DialogueWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private TextMeshProUGUI _text;

		private IWindowService _windowService;
    private IDialogueService _dialogueService;

    [Inject]
		public void Constructor(IWindowService windowService, IDialogueService dialogueService)
		{
			Id = WindowId.DialogueWindow;

			_windowService = windowService;
      _dialogueService = dialogueService;
    }

		protected override void Initialize()
    {
      _closeButton.onClick.AddListener(Close);
      _text.text = _dialogueService.GetDialogueText();
    }

    private void Close() =>
			_windowService.Close(WindowId.DialogueWindow);
	}
}