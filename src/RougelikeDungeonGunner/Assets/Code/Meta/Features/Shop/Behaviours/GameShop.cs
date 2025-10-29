using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class GameShop : MonoBehaviour
  {
    [SerializeField] private Button _weaponUpgradeButton;
    [SerializeField] private Button _weaponBuyButton;
    [SerializeField] private Button _enchantBuyButton;
    [SerializeField] private Button _heroUpgradeBuyButton;

    private IWindowService _windowService;

    [Inject]
    public void Constructor(IWindowService windowService) => 
      _windowService = windowService;

    private void OnEnable()
    {
      _weaponUpgradeButton.onClick.AddListener(OpenWeaponUpgradeShop);
      _weaponBuyButton.onClick.AddListener(OpenWeaponShop);
      _enchantBuyButton.onClick.AddListener(OpenEnchantShop);
      _heroUpgradeBuyButton.onClick.AddListener(OpenHeroUpgradeShop);
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