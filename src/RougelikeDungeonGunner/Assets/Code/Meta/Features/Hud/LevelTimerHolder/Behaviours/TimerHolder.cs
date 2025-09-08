using System;
using TMPro;
using UnityEngine;

namespace Code.Meta.Features.Hud.LevelTimerHolder.Behaviours
{
	public class TimerHolder : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _timeText;

		private void Start() => 
			HideTimeText();

		public void UpdateTimeText(string labelText, float time) => 
			_timeText.text = $"{labelText}: {time:F1}";

		public void HideTimeText() =>
			_timeText.text = string.Empty;

	}
}