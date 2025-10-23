using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class GameOverWindow : BaseWindow
	{
		[SerializeField] private Button _quitButton;
		[SerializeField] private Button _restartButton;

    private IGameOverFacade _facade;

    [Inject]
    public void Constructor(IGameOverFacade facade)
    {
      Id = WindowId.GameOverWindow;

      _facade = facade;
    }

    protected override void Initialize()
    {
      _restartButton.onClick.AddListener(_facade.RestartGame);
      _quitButton.onClick.AddListener(_facade.QuitGame);
      _facade.PlayMusic();
    }
  }
}