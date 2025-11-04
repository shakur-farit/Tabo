using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.StaticData;
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
    private readonly ICoinService _coinService;
    private readonly IStaticDataService _staticDataService;

    public LeaderboardService(ICoinService coinService, IStaticDataService staticDataService)
    {
      _coinService = coinService;
      _staticDataService = staticDataService;
    }

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
      int score = _coinService.GetCurrentCoinCount();
      string id = GetConfig().LeaderboardID;

      try
      {
        await LeaderboardsService.Instance.AddPlayerScoreAsync(id, score);
        Debug.Log($"Очки {score} отправлены на Leaderboard!");
      }
      catch (System.Exception e)
      {
        Debug.LogError($"Ошибка отправки очков: {e.Message}");
      }
    }

    public async UniTask GetLeaderboard()
    {
      int topCount = GetConfig().MaxLeaderCount;
      string id = GetConfig().LeaderboardID;

      try
      {
        LeaderboardScoresPage scoresResponse = await LeaderboardsService.Instance.GetScoresAsync(
          id,
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

    private LeaderboardConfig GetConfig() => 
      _staticDataService.GetLeaderboard();
  }
}