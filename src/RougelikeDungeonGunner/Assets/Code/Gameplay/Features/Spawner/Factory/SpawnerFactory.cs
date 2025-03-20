using Code.Common.Entity;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.Spawner.Factory
{
	public class SpawnerFactory : ISpawnerFactory
	{
		private const int StartingEnemiesAmount = 0;

		private readonly IIdentifierService _identifier;

		public SpawnerFactory(IIdentifierService identifier) => 
			_identifier = identifier;

		public GameEntity CreateEnemySpawner()
		{
			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddCurrentSpawnedEnemyAmount(StartingEnemiesAmount)
				;
		}
	}
}