using Code.Gameplay.Features.Hero.Services;
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
		[SerializeField] private Button _heroUpgradeBuyButton;
		[SerializeField] private Button _currentWeaponInfoButton;
		[SerializeField] private TextMeshProUGUI _coinsText;

    private ICoinService _coinService;
    private ILevelCompleteFacade _facade;

    [Inject]
    public void Constructor(ILevelCompleteFacade facade, ICoinService coinService)
    {
      Id = WindowId.LevelCompleteWindow;

      _facade = facade;
      _coinService = coinService;
    }

    protected override void Initialize()
    {
      _nextLevelButton.onClick.AddListener(_facade.EnterNextLevel);
      _weaponUpgradeButton.onClick.AddListener(_facade.OpenWeaponUpgradeShop);
      _weaponBuyButton.onClick.AddListener(_facade.OpenWeaponShop);
      _enchantBuyButton.onClick.AddListener(_facade.OpenEnchantShop);
      _heroUpgradeBuyButton.onClick.AddListener(_facade.OpenHeroUpgradeShop);
      _currentWeaponInfoButton.onClick.AddListener(_facade.OpenCurrentWeaponInfo);

      CoinsTextUpdate();

      _facade.PlayMusic();
    }

    protected override void SubscribeUpdates() =>
      _coinService.CoinCountChanged += CoinsTextUpdate;

    protected override void UnsubscribeUpdates() =>
      _coinService.CoinCountChanged -= CoinsTextUpdate;

    private void CoinsTextUpdate() =>
      _coinsText.text = _coinService.GetCurrentCoinCount().ToString();
  }
}