using Code.Gameplay.Features.Hero.Services;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class CoinsInformation : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _coinsText;

    private ICoinService _coinService;

    [Inject]
    public void Constructor(ICoinService coinService) => 
      _coinService = coinService;

    private void OnEnable() => 
      _coinService.CoinCountChanged += CoinsTextUpdate;

    private void OnDisable() => 
      _coinService.CoinCountChanged -= CoinsTextUpdate;

    private void CoinsTextUpdate() =>
      _coinsText.text = _coinService.GetCurrentCoinCount().ToString();
  }
}