using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.Features.Weapon.Services;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class CurrentWeaponInfoRenderer : MonoBehaviour
  {
    [SerializeField] private WeaponStatsUIHolder _weaponStatsUIHolder;
    [SerializeField] private EnchantsUIHolder _enchantsUIHolder;
    [SerializeField] private Image _weaponIcon;

    private  IWeaponStatusSetupProvider _statusSetupProvider;
    private  ICurrentWeaponInfoProvider _currentWeapon;

    [Inject]
    public void Constructor(IWeaponStatusSetupProvider statusSetupProvider, ICurrentWeaponInfoProvider currentWeapon)
    {
      _statusSetupProvider = statusSetupProvider;
      _currentWeapon = currentWeapon;
    }

    private void Start() => 
      RenderInfo();

    private void RenderInfo()
    {
      SetSprite();
      ShowEnchants();
      ShowStats();
    }

    private void SetSprite() =>
      _weaponIcon.sprite = _currentWeapon.GetWeaponConfig().Sprite;

    private void ShowStats()
    {
      WeaponConfig config = _currentWeapon.GetWeaponConfig();

      foreach (WeaponStatUIEntry statUIEntry in config.StatsUIEntry)
        _weaponStatsUIHolder.CreateStatUIEntryItem(statUIEntry.StatUIEntryType, config);
    }

    private void ShowEnchants()
    {
      foreach (StatusSetup setup in _statusSetupProvider.GetStatusSetups(_currentWeapon.GetWeaponConfig().TypeId))
        _enchantsUIHolder.CreateEnchantUIEntryItem(setup);
    }
  }
}