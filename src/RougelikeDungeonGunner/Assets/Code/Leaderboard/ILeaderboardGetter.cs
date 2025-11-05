using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Unity.Services.Leaderboards.Models;

namespace Code.Leaderboard
{
  public interface ILeaderboardGetter
  {
    UniTask<List<LeaderboardEntry>> GetLeaderboard();
  }
}