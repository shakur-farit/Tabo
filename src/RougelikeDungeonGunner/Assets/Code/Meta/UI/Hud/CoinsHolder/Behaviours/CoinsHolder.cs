using TMPro;
using UnityEngine;

namespace Code.Meta.UI.Hud.CoinsHolder.Behaviours
{
	public class CoinsHolder : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _coinsText;

		public void UpdateCoinsText(int value) => 
			_coinsText.text = value.ToString("D3");
	}
}