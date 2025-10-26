using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class WeaponBuyWindow : BaseWindow
  {
    [SerializeField] private Button _closeButton;
    [SerializeField] private Button _buyButton;
    [SerializeField] private WeaponToBuyItem _weaponToBuyItem;
    [SerializeField] private WeaponStatsUIHolder _statsUIHolder;

    private IWeaponBuyFacade _facade;

    [Inject]
    public void Construct(IWeaponBuyFacade facade)
    {
      Id = WindowId.WeaponBuyWindow;

      _facade = facade;
    }

    protected override void Initialize()
    {
      _buyButton.onClick.AddListener(_facade.TryBuyWeapon); 
      _closeButton.onClick.AddListener(_facade.CloseWindow);

      _weaponToBuyItem.Setup(_facade.GetWeaponSprite(), _facade.GetWeaponPrice());
      _facade.RenderWeaponStats(_statsUIHolder);
    }
  }
}