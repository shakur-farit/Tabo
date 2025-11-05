using System.Collections.Generic;
using Code.Meta.UI.Windows.Service;
using Unity.Services.Leaderboards.Models;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class LeaderboardWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Transform _holder;

		private IWindowService _windowService;
		private ILeaderboardItemFactory _factory;
		private ILeaderboardGetter _getter;

		[Inject]
		public void Constructor(
			IWindowService windowService, 
			ILeaderboardItemFactory factory,
			ILeaderboardGetter getter)
		{
			Id = WindowId.LeaderboardWindow;

			_windowService = windowService;
			_factory = factory;
			_getter = getter;
		}

		private void OnEnable() => 
			_closeButton.onClick.AddListener(Close);

		private void Start() => 
			CreateLeaderboardItem();

		private void Close() => 
			_windowService.Close(WindowId.LeaderboardWindow);

		private async void CreateLeaderboardItem()
		{
			List<LeaderboardEntry> leaderboard = await _getter.GetLeaderboard();

			foreach (LeaderboardEntry leader in leaderboard)
			{
				LeaderboardItem item = _factory.Create(_holder);
				item.Initialize(leader.Rank + 1, leader.PlayerName, leader.Score);
			}
		}
	}
}