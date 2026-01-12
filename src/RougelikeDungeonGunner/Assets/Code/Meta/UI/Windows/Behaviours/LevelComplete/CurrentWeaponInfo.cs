using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon.Services;
using Code.Meta.UI.Windows.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.LevelComplete
{
  public class CurrentWeaponInfo : MonoBehaviour
  {
    [SerializeField] private Button _currentWeaponInfoButton;
    [SerializeField] private Image _icon;

    private IWindowService _windowService;
    private ICurrentHeroWeaponProvider _weaponProvider;
    private ICurrentWeaponInfoProvider _weaponInfo;

    [Inject]
    public void Constructor(
      IWindowService windowService, 
      ICurrentHeroWeaponProvider weaponProvider,
      ICurrentWeaponInfoProvider weaponInfo)
    {
      _windowService = windowService;
      _weaponProvider = weaponProvider;
      _weaponInfo = weaponInfo;
    }

    private void OnEnable()
    {
      _currentWeaponInfoButton.onClick.AddListener(OpenCurrentWeaponInfo);
      _weaponProvider.WeaponChanged += UpdateIcon;
    }

    private void OnDisable() => 
      _weaponProvider.WeaponChanged -= UpdateIcon;

    private void Start() => 
      UpdateIcon();

    private void OpenCurrentWeaponInfo() =>
      _windowService.Open(WindowId.CurrentWeaponInfoWindow);

    private void UpdateIcon() => 
      _icon.sprite = _weaponInfo.GetWeaponConfig().Sprite;
  }
}