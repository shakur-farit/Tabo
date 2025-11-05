using Code.Common.Extensions;
using Code.Meta.Features.Shop.HeroUpgrade.Configs;
using Code.Meta.Features.Shop.Services;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Services;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.Shop.HeroUpgrade.Behaviours
{
  public class HeroUpgradeShopItem : MonoBehaviour
  {
    [SerializeField] private Image _icon;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _priceText;
    [SerializeField] private Button _showHeroUpgradeBuyButton;

    private HeroUpgradeTypeId _heroUpgradeTypeId;
    private int _price;
    private float _value;

    private IWindowService _windowService;
    private IHeroUpgradeShopService _shopService;

    [Inject]
    public void Constructor(IWindowService windowService, IHeroUpgradeShopService shopService)
    {
      _windowService = windowService;
      _shopService = shopService;
    }

    private void Start() =>
      _showHeroUpgradeBuyButton.onClick.AddListener(OpenEnchantBuyWindow);

    public void Setup(HeroUpgradeShopItemConfig config)
    {
      _icon.sprite = config.Sprite;
      _name.text = config.TypeId.ToDisplayName();
      _priceText.text = config.Price.ToString();
      _price = config.Price;
      _value = config.UpgradeValue;
      _heroUpgradeTypeId = config.TypeId;
    }

    private void OpenEnchantBuyWindow()
    {
      _shopService.SetHeroUpgradePrice(_price);
      _shopService.SetHeroUpgradeValue(_value);
      _shopService.SetHeroUpgradeSprite(_icon.sprite);
      _shopService.SetHeroUpgradeTypeId(_heroUpgradeTypeId);

      _windowService.Open(WindowId.HeroUpgradeBuyWindow);
    }
  }
}