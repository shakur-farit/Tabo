using Code.Gameplay.Features.Enemy.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Enemy
{
	public sealed class EnemyFeature : Feature
	{
		public EnemyFeature(ISystemsFactory systems)
		{
			Add(systems.Create<SpawnEnemiesSystem>());
			Add(systems.Create<EnemyMoveSystem>());
			Add(systems.Create<AnimateEnemyMovementSystem>());
			Add(systems.Create<AnimateEnemyDirectionWithWeaponSystem>());
			Add(systems.Create<AnimateEnemyDirectionWithNoWeaponSystem>());
			Add(systems.Create<CreateWeaponForEnemySystem>());
			Add(systems.Create<EnemyDeathSystem>());
			Add(systems.Create<DropLootOnEnemyDeadSystem>());
			Add(systems.Create<FinalizeEnemyDeathProcessingSystem>());
		}
	}
}