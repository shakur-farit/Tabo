using Code.Common.Entity;
using Code.Gameplay.Features.Levels.Configs;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.Levels
{
	public class EnemyWaveFactory : IEnemyWaveFactory
	{
		private readonly IIdentifierService _identifier;

		public EnemyWaveFactory(IIdentifierService identifier) => 
			_identifier = identifier;

		public GameEntity CreateEnemyWave(EnemyWave enemyWave)
		{
			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddEnemyWave(enemyWave)
				;
		}
	}
}