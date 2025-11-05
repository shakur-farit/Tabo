using Code.Gameplay.Features.Score.Services;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Score.Behaviours
{
	public class ScoreTextUpdater : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _score;
		
		private IScoreService _scoreService;

		[Inject]
		public void Constructor(IScoreService scoreService) => 
			_scoreService = scoreService;

		private void OnEnable() => 
			_scoreService.ScoreChanged += UpdateScoreText;

		private void OnDisable() => 
			_scoreService.ScoreChanged -= UpdateScoreText;

		private void Start() => 
			UpdateScoreText();

		private void UpdateScoreText() => 
			_score.text = $"Score: {_scoreService.GetCurrentScoreCount()}";
	}
}