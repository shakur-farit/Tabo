using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class HeroUpgradeToBuyItem : MonoBehaviour

  {
    [SerializeField] private Image _icon;
    [SerializeField] private TextMeshProUGUI _price;
    [SerializeField] private TextMeshProUGUI _value;

    public void Setup(Sprite sprite, int price, float value)
    {
      _icon.sprite = sprite;
      _price.text = price.ToString();

      if (value > 0)
        _value.text = $"+{value}";
    }
  }
}