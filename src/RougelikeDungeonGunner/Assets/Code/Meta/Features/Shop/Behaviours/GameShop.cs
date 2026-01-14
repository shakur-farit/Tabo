using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon.Services;
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
    private ICurrentHeroWeaponProvider _currentWeapon;
    private ICurrentWeaponInfoProvider _weaponInfo;

    [Inject]
    public void Constructor(
	    IWindowService windowService, 
	    IStaticDataService staticDataService, 
	    ICurrentHeroWeaponProvider currentWeapon, 
	    ICurrentHeroTypeIdProvider heroType,
      ICurrentWeaponInfoProvider weaponInfo)
    {
	    _windowService = windowService;
	    _staticDataService = staticDataService;
	    _heroType = heroType;
	    _currentWeapon = currentWeapon;
      _weaponInfo = weaponInfo;
    }

    private void OnEnable()
    {
      _weaponUpgradeButton.onClick.AddListener(OpenWeaponUpgradeShop);
      _weaponBuyButton.onClick.AddListener(OpenWeaponShop);
      _enchantBuyButton.onClick.AddListener(OpenEnchantShop);
      _heroUpgradeBuyButton.onClick.AddListener(OpenHeroUpgradeShop);

      _currentWeapon.WeaponChanged += UpdateWeaponUpgradeShopIcon;
    }

    private void OnDisable() =>
      _currentWeapon.WeaponChanged -= UpdateWeaponUpgradeShopIcon;

    private void Start()
    {
      UpdateWeaponUpgradeShopIcon();

      UpdateHeroUpgradeShopIcon();
    }

    public void OpenWeaponUpgradeShop() =>
      _windowService.Open(WindowId.WeaponUpgradeWindow);

    public void OpenWeaponShop() =>
      _windowService.Open(WindowId.WeaponShopWindow);

    public void OpenEnchantShop() =>
      _windowService.Open(WindowId.EnchantShopWindow);

    public void OpenHeroUpgradeShop() =>
      _windowService.Open(WindowId.HeroUpgradeShopWindow);

    private void UpdateWeaponUpgradeShopIcon() => 
      _weaponUpgradeShopIcon.sprite = _weaponInfo.GetWeaponConfig().Sprite;

    private void UpdateHeroUpgradeShopIcon() =>
      _heroUpgradeShopIcon.sprite =
        _staticDataService.GetHeroConfig(_heroType.CurrentHeroTypeId)
          .ShopIcon;
  }
}