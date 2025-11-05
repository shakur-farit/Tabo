using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.Features.Shop.HeroUpgrade.Behaviours
{
  public class HeroUpgradePurchaseItemView : MonoBehaviour

  {
    [SerializeField] private Image _icon;
    [SerializeField] private TextMeshProUGUI _price;
    [SerializeField] private TextMeshProUGUI _value;

    public void Initialize(Sprite sprite, int price, float value)
    {
      _icon.sprite = sprite;
      _price.text = price.ToString();

      if (value > 0)
        _value.text = $"+{value}";
    }
  }
}