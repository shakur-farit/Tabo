using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Hero.Configs;
using Code.Gameplay.StaticData;
using Code.Progress.Provider;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.Hud.HeroSelector.Behaviours
{
	public class HeroSelectorBehaviour : MonoBehaviour
	{
		[SerializeField] private HeroUI _heroUI;
		[SerializeField] private Button _nextHeroButton;
		[SerializeField] private Button _previousHeroButton;

		private List<HeroConfig> _heroConfigs;
		private int _currentIndex = 0;

		private IStaticDataService _staticDataService;
		private IProgressProvider _progressProvider;

		[Inject]
		public void Constructor(IStaticDataService staticDataService, IProgressProvider progressProvider)
		{
			_staticDataService = staticDataService;
			_progressProvider = progressProvider;
		}

		private void OnEnable()
		{
			_nextHeroButton.onClick.AddListener(SwitchToNextHero);
			_previousHeroButton.onClick.AddListener(SwitchToPreviousHero);
		}
		private void Start()
		{
			_heroConfigs = _staticDataService.GetAllHeroConfigs().ToList();
			UpdateHeroUI(_heroConfigs[_currentIndex]);
			UpdateNavigationButtons();
			UpdateCurrentHero(_heroConfigs[_currentIndex].TypeId);
		}

		private void SwitchToNextHero()
		{
			if (_currentIndex < _heroConfigs.Count - 1)
				_currentIndex++;

			UpdateHeroUI(_heroConfigs[_currentIndex]);
			Debug.Log(_heroConfigs[_currentIndex].TypeId);
			UpdateCurrentHero(_heroConfigs[_currentIndex].TypeId);
			UpdateNavigationButtons();
		}

		private void SwitchToPreviousHero()
		{
			if (_currentIndex > 0)
				_currentIndex--;

			UpdateHeroUI(_heroConfigs[_currentIndex]);
			Debug.Log(_heroConfigs[_currentIndex].TypeId);
			UpdateCurrentHero(_heroConfigs[_currentIndex].TypeId);
			UpdateNavigationButtons();
		}

		private void UpdateHeroUI(HeroConfig config) => 
			_heroUI.UpdateHeroUI(config);

		private void UpdateCurrentHero(HeroTypeId typeId) => 
			_progressProvider.HeroData.CurrentHeroTypeId = typeId;

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
