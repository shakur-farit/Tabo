using Code.Common.Extensions;
using Code.Gameplay.Features.Hero.Services;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Information.HeroInformation.Behaviours
{
  public class HeroNameRenderer : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _nameText;

    private ICurrentHeroTypeIdProvider _currentHero;

    [Inject]
    public void Constructor(ICurrentHeroTypeIdProvider currentHero) => 
      _currentHero = currentHero;

    private void Start() => 
      UpdateTextName();

    private void UpdateTextName() => 
      _nameText.text = _currentHero.CurrentHeroTypeId.ToDisplayName();
  }
}