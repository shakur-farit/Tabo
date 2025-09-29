using Code.Gameplay.Features.Music;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using TMPro;
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
		[SerializeField] private Button _currentWeaponInfoButton;
		[SerializeField] private TextMeshProUGUI _coinsText;

		private IGameStateMachine _stateMachine;
		private IWindowService _windowService;
		private IProgressProvider _progressProvider;
		private IMusicClipSetter _clipSetter;

		[Inject]
		public void Constructor(
			IGameStateMachine stateMachine, 
			IWindowService windowService,
			IProgressProvider progressProvider,
			IMusicClipSetter clipSetter)
		{
			Id = WindowId.LevelCompleteWindow;

			_stateMachine = stateMachine;
			_windowService = windowService;
			_progressProvider = progressProvider;
			_clipSetter = clipSetter;
		}

		protected override void Initialize()
		{
			_nextLevelButton.onClick.AddListener(EnterToBattle);
			_weaponUpgradeButton.onClick.AddListener(OpenWeaponUpgradeWindow);
			_weaponBuyButton.onClick.AddListener(OpenWeaponBuyWindow);
			_enchantBuyButton.onClick.AddListener(OpenEnchantBuyWindow);
			_currentWeaponInfoButton.onClick.AddListener(OpenCurrentWeaponInfoWindow);
			
			CoinsTextUpdate();
			PlayDungeonMelancholyMusic();
		}

		protected override void SubscribeUpdates() => 
			_progressProvider.HeroData.CoinsChanged += CoinsTextUpdate;

		protected override void UnsubscribeUpdates() => 
			_progressProvider.HeroData.CoinsChanged -= CoinsTextUpdate;

		private void EnterToBattle() =>
			_stateMachine.Enter<BattleEnterState>();

		private void OpenWeaponUpgradeWindow() =>
			_windowService.Open(WindowId.WeaponUpgradeWindow);

		private void OpenWeaponBuyWindow() =>
			_windowService.Open(WindowId.WeaponBuyWindow);

		private void OpenEnchantBuyWindow() =>
			_windowService.Open(WindowId.EnchantBuyWindow);

		private void OpenCurrentWeaponInfoWindow() => 
			_windowService.Open(WindowId.CurrentWeaponInfoWindow);

		private void CoinsTextUpdate() => 
			_coinsText.text = _progressProvider.HeroData.CurrentCoinsCount.ToString();

		private void PlayDungeonMelancholyMusic() => 
			_clipSetter.SetClip(MusicTypeId.DungeonMelancholy);
	}
}