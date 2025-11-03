using Code.Progress.Provider;
using Cysharp.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Leaderboards;
using Unity.Services.Leaderboards.Models;
using UnityEngine;

namespace Code.Meta
{
  public class LeaderboardService : ILeaderboardInitializer, ILeaderboardUpdater, ILeaderboardGetter
  {
    private readonly IProgressProvider _progressProvider;

    public LeaderboardService(IProgressProvider progressProvider) => 
      _progressProvider = progressProvider;

    public async UniTask Initialize()
    {
      try
      {
        await UnityServices.InitializeAsync();

        await AuthenticationService.Instance.SignInAnonymouslyAsync();

        Debug.Log("UGS и аутентификация завершены!");
      }
      catch (System.Exception e)
      {
        Debug.LogError($"Ошибка инициализации UGS: {e.Message}");
      }
    }

    public async UniTask UpdateLeaderboard()
    {
      int score = _progressProvider.ProgressData.ScoreData.Score;

      try
      {
        await LeaderboardsService.Instance.AddPlayerScoreAsync("TaboLeaderboard", score);
        Debug.Log($"Очки {score} отправлены на Leaderboard!");
      }
      catch (System.Exception e)
      {
        Debug.LogError($"Ошибка отправки очков: {e.Message}");
      }
    }

    public async UniTask GetLeaderboard(int topCount = 10)
    {
      try
      {
        LeaderboardScoresPage scoresResponse = await LeaderboardsService.Instance.GetScoresAsync(
          "TaboLeaderboard",
          new GetScoresOptions { Limit = topCount }
        );

        foreach (LeaderboardEntry entry in scoresResponse.Results)
        {
          Debug.Log($"Rank {entry.Rank} - Player {entry.PlayerId} - Score {entry.Score}");
        }
      }
      catch (System.Exception e)
      {
        Debug.LogError($"Ошибка получения лидеров: {e.Message}");
      }
    }
  }
}