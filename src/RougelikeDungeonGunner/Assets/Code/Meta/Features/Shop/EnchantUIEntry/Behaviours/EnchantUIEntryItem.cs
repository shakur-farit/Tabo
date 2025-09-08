using Code.Common.Extensions;
using Code.Gameplay.Features.Statuses;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.Shop.EnchantUIEntry.Behaviours
{
	public class EnchantUIEntryItem : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private Image _icon;
		[SerializeField] private Button _showEnchantStatsButton;

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;
		private StatusSetup _setup;
		private EnchantUIEntryTypeId _id;

		[Inject]
		public void Constructor(IWindowService windowService, IProgressProvider progressProvider)
		{
			_windowService = windowService;
			_progressProvider = progressProvider;
		}

		private void Start() => 
			_showEnchantStatsButton.onClick.AddListener(OpenEnchantStatsWindow);

		private void OpenEnchantStatsWindow()
		{
			_progressProvider.WeaponData.SelectedEnchantUIStats = _setup;
			_progressProvider.WeaponData.SelectedEnchantUITypeId = _id;

			_windowService.Open(WindowId.EnchantStatsWindow);
		}

		public void Setup(EnchantUIEntryTypeId id, Sprite sprite, StatusSetup setup)
		{
			_name.text = id.ToDisplayName();
			_icon.sprite = sprite;

			_setup = setup;
			_id = id;
		}
	}
}