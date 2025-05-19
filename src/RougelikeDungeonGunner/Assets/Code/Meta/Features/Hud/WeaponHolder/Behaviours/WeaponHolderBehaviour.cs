using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Meta.UI.WeaponHolder.Behaviours
{
	public class WeaponHolderBehaviour : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _weaponName;
		[SerializeField] private TextMeshProUGUI _infinitiyAmmoText;

		private void Awake() => 
			_infinitiyAmmoText.gameObject.SetActive(false);

		public void UpdateWeaponIcon(Sprite sprite) =>
			_icon.sprite = sprite;

		public void UpdateWeaponName(string name) =>
			_weaponName.text = name;

		public void SetActiveOnInfinityAmmo() => 
			_infinitiyAmmoText.gameObject.SetActive(true);

		public void SetInactiveOnInfinityAmmo() =>
			_infinitiyAmmoText.gameObject.SetActive(false);
	}
}