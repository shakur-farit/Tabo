using System.Collections.Generic;
using Code.Meta.Features.Hud.Services;
using Code.Meta.UI.Windows.Services;
using Entitas;

namespace Code.Meta.Features.Hud
{
	public class CloseHudWindowSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IHudDependPlatformProvider _hudDependPlatform;
		private readonly IWindowService _windowService;
		private readonly IGroup<GameEntity> _levels;

		public CloseHudWindowSystem(
			GameContext game,
			IHudDependPlatformProvider hudDependPlatform,
			IWindowService windowService)
		{
			_hudDependPlatform = hudDependPlatform;
			_windowService = windowService;
			
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Level,
					GameMatcher.HudAvailable,
					GameMatcher.Processed));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				_windowService.Close(_hudDependPlatform.GetHud());
				level.isHudAvailable = false;
			}
		}
	}
}