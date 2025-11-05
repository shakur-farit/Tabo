using TMPro;
using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class LeaderboardItem : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _rank;
		[SerializeField] private TextMeshProUGUI _playerName;
		[SerializeField] private TextMeshProUGUI _score;

		public void Initialize(int rank, string playerName, double score)
		{
			_rank.text = rank.ToString();
			_playerName.text = playerName;
			_score.text = score.ToString();
		}
	}
}