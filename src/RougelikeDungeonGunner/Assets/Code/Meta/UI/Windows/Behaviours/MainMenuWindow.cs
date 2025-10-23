using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class MainMenuWindow : BaseWindow
	{
		[SerializeField] private Button _startGameButton;
		[SerializeField] private Button _settingsButton;
		[SerializeField] private Button _quitButton;

    private IMainMenuFacade _facade;

    [Inject]
		public void Constructor(IMainMenuFacade facade)
		{
			Id = WindowId.MainMenuWindow;

      _facade = facade;
    }

    protected override void Initialize()
    {
      _startGameButton.onClick.AddListener(_facade.StartGame);
      _settingsButton.onClick.AddListener(_facade.OpenSettings);
      _quitButton.onClick.AddListener(_facade.QuitGame);
    }
  }
}