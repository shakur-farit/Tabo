using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours
{
	public interface ILeaderboardItemFactory
	{
		LeaderboardItem Create(Transform parent);
	}
}