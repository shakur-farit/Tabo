using UnityEngine;

namespace Code.Meta
{
  [CreateAssetMenu(menuName = "Dungeon Gunner/Leaderboard Config", fileName = "LeaderboardConfig")]
  public class LeaderboardConfig : ScriptableObject
  {
    public string LeaderboardID;
    public int MaxLeaderCount;
    public GameObject ItemViewPrefab;
  }
}