using TMPro;
using UnityEngine;

namespace Code.Gameplay.Features.Enchants
{
	public class EnchantTimeLeftVisual : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _timeLeftText;

		public void UpdateLeftTimeText(float value) => 
			_timeLeftText.text = ((int)value).ToString();
	}
}