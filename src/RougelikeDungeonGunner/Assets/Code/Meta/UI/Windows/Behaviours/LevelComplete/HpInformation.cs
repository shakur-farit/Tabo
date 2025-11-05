using Code.Gameplay.Features.Hero.Services;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.LevelComplete
{
	public class HpInformation : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _hpText;

		private IHeroHpProvider _hpProvider;

		[Inject]
		public void Constructor(IHeroHpProvider hpProvider) => 
			_hpProvider = hpProvider;

		private void OnEnable() => 
			_hpProvider.HpChanged += UpdateHpText;

		private void OnDisable() => 
			_hpProvider.HpChanged -= UpdateHpText;

		private void Start() => 
			UpdateHpText();

		private void UpdateHpText()
		{
			float hpPercent = _hpProvider.GetHpPercent();
			_hpText.text = $"{hpPercent:0}%";
		}
	}
}