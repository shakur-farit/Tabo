using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Enemies
{
	public class EnemyFactory : IEnemyFactory
	{
		private const string EnemyViewPath = "Enemy";

		private readonly IIdentifierService _identifier;


		public EnemyFactory(IIdentifierService identifier) =>
			_identifier = identifier;

		public GameEntity Create(Vector3 at)
		{
			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWorldPosition(at)
					.AddDirection(Vector2.zero)
					.AddSpeed(2)
					.AddViewPath(EnemyViewPath)
					.With(x => x.isEnemy = true)
				;
		}
	}
}