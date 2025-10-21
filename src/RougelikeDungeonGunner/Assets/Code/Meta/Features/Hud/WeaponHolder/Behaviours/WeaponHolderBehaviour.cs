using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.Features.Hud.WeaponHolder.Behaviours
{
	public class WeaponHolderBehaviour : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _weaponName;
		[SerializeField] private TextMeshProUGUI _infinitiyAmmoText;
		[SerializeField] private TextMeshProUGUI _currentAmmoCountText;

		private void Awake() => 
			_infinitiyAmmoText.gameObject.SetActive(false);

		public void UpdateWeaponIcon(Sprite sprite) =>
			_icon.sprite = sprite;

		public void UpdateWeaponName(string name) =>
			_weaponName.text = name;

		public void SetActiveOnInfinityAmmoText() => 
			_infinitiyAmmoText.gameObject.SetActive(true);

		public void SetInactiveOnInfinityAmmoText() =>
			_infinitiyAmmoText.gameObject.SetActive(false);

		public void SetActiveCurrentAmmoText() =>
			_currentAmmoCountText.gameObject.SetActive(true);

		public void SetInactiveCurrentAmmoText() =>
			_currentAmmoCountText.gameObject.SetActive(false);

		public void UpdateCurrentAmmoCountText(int current, int max) => 
			_currentAmmoCountText.text = $"{current}/{max}";
	}
}