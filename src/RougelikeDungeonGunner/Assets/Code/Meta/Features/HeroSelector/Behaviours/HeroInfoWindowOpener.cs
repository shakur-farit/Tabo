using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.HeroSelector.Behaviours
{
	public class HeroInfoWindowOpener : MonoBehaviour
	{
		[SerializeField] private Button _infoOpepButton;

		private IWindowService _windowService;

		[Inject]
		public void Constructor(IWindowService windowService) => 
			_windowService = windowService;

		private void OnEnable() => 
			_infoOpepButton.onClick.AddListener(OpenHeroInfoWindow);

		private void OpenHeroInfoWindow()
		{
			Debug.Log("Click");
			_windowService.Open(WindowId.HeroInfoWindow);
		}
	}
}