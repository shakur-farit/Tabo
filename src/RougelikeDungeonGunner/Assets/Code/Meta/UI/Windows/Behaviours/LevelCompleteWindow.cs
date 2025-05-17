using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class LevelCompleteWindow : BaseWindow
	{
		[SerializeField] private Button _nextLevelButton;
		[SerializeField] private Button _weaponUpgradeButton;
		[SerializeField] private Button _weaponBuyButton;
		[SerializeField] private Button _enchantBuyButton;
		private IGameStateMachine _stateMachine;
		private IWindowService _windowService;

		[Inject]
		public void Constructor(IGameStateMachine stateMachine, IWindowService windowService)
		{
			Id = WindowId.LevelCompleteWindow;

			_stateMachine = stateMachine;
			_windowService = windowService;
		}

		protected override void Initialize()
		{
			_nextLevelButton.onClick.AddListener(EnterToBattle);
			_weaponUpgradeButton.onClick.AddListener(OpenWeaponUpgradeWindow);
			_weaponBuyButton.onClick.AddListener(OpenWeaponBuyWindow);
			_enchantBuyButton.onClick.AddListener(OpenEnchantBuyWindow);
		}

		private void EnterToBattle() =>
			_stateMachine.Enter<BattleEnterState>();

		private void OpenWeaponUpgradeWindow() => 
			_windowService.Open(WindowId.WeaponUpgradeWindow);

		private void OpenWeaponBuyWindow() =>
			_windowService.Open(WindowId.WeaponBuyWindow);

		private void OpenEnchantBuyWindow() =>
			_windowService.Open(WindowId.EnchantBuyWindow);
	}
}