using Code.Leaderboard.Behaviours;
using UnityEngine;

namespace Code.Leaderboard.Factory
{
	public interface ILeaderboardItemFactory
	{
		LeaderboardItem Create(Transform parent);
	}
}