using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.StaticData;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.Shop.Behaviours
{
  public class GameShop : MonoBehaviour
  {
    [SerializeField] private Button _weaponUpgradeButton;
    [SerializeField] private Button _weaponBuyButton;
    [SerializeField] private Button _enchantBuyButton;
    [SerializeField] private Button _heroUpgradeBuyButton;
    [SerializeField] private Image _weaponUpgradeShopIcon;
    [SerializeField] private Image _heroUpgradeShopIcon;

    private IWindowService _windowService;
    private IStaticDataService _staticDataService;
    private ICurrentHeroTypeIdProvider _heroType;

    [Inject]
    public void Constructor(
	    IWindowService windowService, 
	    IStaticDataService staticDataService, 
	    ICurrentHeroTypeIdProvider heroType)
    {
	    _windowService = windowService;
	    _staticDataService = staticDataService;
	    _heroType = heroType;
    }

    private void OnEnable()
    {
      _weaponUpgradeButton.onClick.AddListener(OpenWeaponUpgradeShop);
      _weaponBuyButton.onClick.AddListener(OpenWeaponShop);
      _enchantBuyButton.onClick.AddListener(OpenEnchantShop);
      _heroUpgradeBuyButton.onClick.AddListener(OpenHeroUpgradeShop);
    }

    private void Start()
    {
	    _weaponUpgradeShopIcon.sprite =
		    _staticDataService.GetHeroConfig(_heroType.CurrentHeroTypeId)
			    .ShopIcon;

	    _heroUpgradeShopIcon.sprite =
		    _staticDataService.GetHeroConfig(_heroType.CurrentHeroTypeId)
			    .ShopIcon;

		}

		public void OpenWeaponUpgradeShop() =>
      _windowService.Open(WindowId.WeaponUpgradeWindow);

    public void OpenWeaponShop() =>
      _windowService.Open(WindowId.WeaponShopWindow);

    public void OpenEnchantShop() =>
      _windowService.Open(WindowId.EnchantShopWindow);

    public void OpenHeroUpgradeShop() =>
      _windowService.Open(WindowId.HeroUpgradeShopWindow);
  }
}