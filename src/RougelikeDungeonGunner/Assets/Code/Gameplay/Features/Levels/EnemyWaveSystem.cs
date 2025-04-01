using Code.Common.Entity;
using Code.Common.Extensions;
using Entitas;

namespace Code.Gameplay.Features.Levels
{
	public class EnemyWaveSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _levels;

		public EnemyWaveSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemyWaves)
				.NoneOf(GameMatcher.WaveAvailable));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
			{
				CreateEntity.Empty()
					.With(x => x.isWave = true)
					.With(x => x.isWaveAvailable = true)
					;
			}
		}
	}
}