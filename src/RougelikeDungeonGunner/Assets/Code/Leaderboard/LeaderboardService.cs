using System.Collections.Generic;
using Code.Gameplay.Features.Score.Services;
using Code.Gameplay.StaticData;
using Code.Leaderboard.Config;
using Cysharp.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Leaderboards;
using Unity.Services.Leaderboards.Models;
using UnityEngine;

namespace Code.Leaderboard
{
  public class LeaderboardService : ILeaderboardInitializer, ILeaderboardUpdater, ILeaderboardGetter
  {
    private readonly IScoreService _scoreService;
    private readonly IStaticDataService _staticDataService;

    public LeaderboardService(IScoreService scoreService, IStaticDataService staticDataService)
    {
      _scoreService = scoreService;
      _staticDataService = staticDataService;
    }

    public async UniTask Initialize()
    {
      try
      {
        await UnityServices.InitializeAsync();

        await AuthenticationService.Instance.SignInAnonymouslyAsync();
      }
      catch (System.Exception e)
      {
        Debug.LogError($"Initialization UGS: {e.Message}");
      }
    }

    public async UniTask UpdateLeaderboard()
    {
      int score = _scoreService.GetCurrentScoreCount();
      string id = GetConfig().LeaderboardID;

      try
      {
        await LeaderboardsService.Instance.AddPlayerScoreAsync(id, score);
      }
      catch (System.Exception e)
      {
        Debug.LogError($"Setting error: {e.Message}");
      }
    }

    public async UniTask<List<LeaderboardEntry>> GetLeaderboard()
    {
      int topCount = GetConfig().MaxLeaderCount;
      string id = GetConfig().LeaderboardID;

      List<LeaderboardEntry> results = new();

			try
      {
	      LeaderboardScoresPage scoresResponse = await LeaderboardsService.Instance.GetScoresAsync(
          id,
          new GetScoresOptions { Limit = topCount }
        );

        results = scoresResponse.Results;
      }
      catch (System.Exception e)
      {
        Debug.LogError($"Getting error: {e.Message}");
      }

			return results;
    }

    private LeaderboardConfig GetConfig() => 
      _staticDataService.GetLeaderboard();
  }
}