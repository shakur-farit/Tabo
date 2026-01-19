using TMPro;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Behaviours
{
	public class EnemyHpBar : MonoBehaviour
	{
		[SerializeField] private Transform _hp;
		[SerializeField] private TextMeshPro _hpText;

		public void UpdateHpView(float current, float max)
		{
			float fill = Mathf.Clamp01(current / max);

			_hp.localScale = new Vector3(fill, 1f, 1f);

			int percent = Mathf.RoundToInt(fill * 100f);
			_hpText.text = $"{percent}%";
		}
	}
}