using TMPro;
using UnityEngine;

namespace Assets.Code.Meta.Features.Hud.CoinsHolder.Behaviours
{
	public class CoinsHolderBehaviour : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _coinsText;

		public void UpdateCoinsText(int value) => 
			_coinsText.text = value.ToString("D3");
	}
}