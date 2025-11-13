using Code.Meta.Features.Hud.HeroHeartHolder.Factory;
using System.Collections.Generic;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.StaticData;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Hud.HeroHeartHolder.Behaviours
{
	public class HeartHolder : MonoBehaviour
	{
    [SerializeField] private Transform _holder;
    [SerializeField] private TextMeshProUGUI _hpText;


    private readonly List<GameObject> _heartIconsBuffer = new();
    private int _maxHeartSprite;

    private IHeartUIFactory _factory;
    private IHeroHpProvider _hpProvider;
    private IStaticDataService _staticDataService;

    [Inject]
		public void Constructor(IHeartUIFactory factory, IHeroHpProvider hpProvider, IStaticDataService staticDataService)
		{
			_factory = factory;
			_hpProvider = hpProvider;
      _staticDataService = staticDataService;

      _maxHeartSprite = _staticDataService.GetHudConfig().MaxHeartSpritesCount;
    }

		public void UpdateHeartUICount(float currentHp, float maxHp)
		{
			int heartsToShow = Mathf.CeilToInt((currentHp / maxHp) * _maxHeartSprite);
			heartsToShow = Mathf.Clamp(heartsToShow, 0, _maxHeartSprite);

			CreateHeartUI();

			for (int i = 0; i < _heartIconsBuffer.Count; i++)
				_heartIconsBuffer[i].SetActive(i < heartsToShow);

			UpdateHpText();
		}

		private void CreateHeartUI()
		{
			while (_heartIconsBuffer.Count < _maxHeartSprite)
			{
				GameObject icon = _factory.CreateHeartUI(_holder);
				icon.SetActive(false);
				_heartIconsBuffer.Add(icon);
			}
		}

    private void UpdateHpText()
    {
	    float hpPercent = _hpProvider.GetHpPercent();
      _hpText.text = $"{hpPercent:0}%";
    }
	}
}