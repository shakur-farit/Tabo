using Code.Gameplay.Features.Levels.Configs;

namespace Code.Gameplay.Features.Levels
{
	public interface IEnemyWaveFactory
	{
		GameEntity CreateEnemyWave(EnemyWave enemyWave);
	}
}