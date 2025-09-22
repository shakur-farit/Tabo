using Assets.Code.Infrastructure.Loading;
using Assets.Code.Infrastructure.States.GameStates;
using Assets.Code.Infrastructure.States.StateMachine;
using Assets.Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Assets.Code.Meta.UI.Windows.Behaviours
{
	public class MainMenuWindow : BaseWindow
	{
		[SerializeField] private Button _startGameButton;

		private IGameStateMachine _stateMachine;
		private IWindowService _windowService;

		[Inject]
		public void Constructor(IGameStateMachine stateMachine, IWindowService windowService)
		{
			Id = WindowId.MainMenuWindow;

				_stateMachine = stateMachine;
			_windowService = windowService;
		}

		protected override void Initialize()
		{
			_startGameButton.onClick.AddListener(EnterToBattle);
			_startGameButton.onClick.AddListener(CloseWindow);
		}

		private void EnterToBattle() => 
			_stateMachine.Enter<LoadingBattleState, string>(Scenes.Gameplay);

		private void CloseWindow() => 
			_windowService.Close(WindowId.MainMenuWindow);
	}
}