using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Unity.Services.Leaderboards.Models;

namespace Code.Meta
{
  public interface ILeaderboardGetter
  {
    UniTask<List<LeaderboardEntry>> GetLeaderboard();
  }
}