using Code.Gameplay.Features.Coin.Services;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.LevelComplete
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

    private void Start() => 
	    CoinsTextUpdate();

    private void CoinsTextUpdate() =>
      _coinsText.text = _coinService.GetCurrentCoinCount().ToString();
  }
}