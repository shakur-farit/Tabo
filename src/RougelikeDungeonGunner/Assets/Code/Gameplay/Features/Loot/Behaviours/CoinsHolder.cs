using TMPro;
using UnityEngine;

namespace Code.Gameplay.Features.Loot.Behaviours
{
	public class CoinsHolder : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _coinsText;

		public void UpdateCoinsText(int value)
		{
			Debug.Log(value);
			_coinsText.text = value.ToString("D3");
		}
	}
}