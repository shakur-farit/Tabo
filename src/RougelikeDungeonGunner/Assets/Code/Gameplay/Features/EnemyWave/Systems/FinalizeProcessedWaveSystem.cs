using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Levels
{
	public class FinalizeProcessedWaveSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _waves;
		private readonly List<GameEntity> _buffer = new(1);

		public FinalizeProcessedWaveSystem(GameContext game)
		{
			_waves = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemyWave,
					GameMatcher.Processed));
		}

		public void Execute()
		{
			foreach (GameEntity wave in _waves.GetEntities(_buffer)) 
				wave.isDestructed = true;
		}
	}
}