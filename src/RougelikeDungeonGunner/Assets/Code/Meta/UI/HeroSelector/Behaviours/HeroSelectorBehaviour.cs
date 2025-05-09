using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Hero.Configs;
using Code.Gameplay.StaticData;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.UIRoot.Factory
{
	public class HeroSelectorBehaviour : MonoBehaviour
	{
		[SerializeField] private Button _nextHeroButton;
		[SerializeField] private Button _previousHeroButton;

		private List<HeroConfig> _heroConfigs;
		private int _currentIndex = 0;

		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(IStaticDataService staticDataService) =>
			_staticDataService = staticDataService;

		private void OnEnable()
		{
			_nextHeroButton.onClick.AddListener(SwitchToNextHero);
			_previousHeroButton.onClick.AddListener(SwitchToPreviousHero);
		}
		private void Start()
		{
			_heroConfigs = _staticDataService.GetAllHeroConfigs().ToList();
			UpdateUI();
			UpdateNavigationButtons();
		}

		private void SwitchToNextHero()
		{
			if (_currentIndex < _heroConfigs.Count - 1)
				_currentIndex++;

			UpdateUI();
			UpdateNavigationButtons();
		}

		private void SwitchToPreviousHero()
		{
			if (_currentIndex > 0)
				_currentIndex--;

			UpdateUI();
			UpdateNavigationButtons();
		}

		private void UpdateUI()
		{
		}

		private void UpdateNavigationButtons()
		{
			if (_heroConfigs.Count <= 1)
			{
				_nextHeroButton.gameObject.SetActive(false);
				_previousHeroButton.gameObject.SetActive(false);
				return;
			}

			_previousHeroButton.gameObject.SetActive(_currentIndex > 0);
			_nextHeroButton.gameObject.SetActive(_currentIndex < _heroConfigs.Count - 1);
		}
	}
}
