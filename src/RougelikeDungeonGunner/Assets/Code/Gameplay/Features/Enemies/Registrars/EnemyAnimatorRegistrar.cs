using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Enemies.Behaviours
{
	public class EnemyAnimatorRegistrar : EntityComponentRegistrar
	{
		[SerializeField] public EnemyAnimator _enemyAnimator;

		public override void RegisterComponents() =>
			Entity
				.AddEnemyAnimator(_enemyAnimator);

		public override void UnregisterComponents()
		{
			if (Entity.hasEnemyAnimator)
				Entity.RemoveEnemyAnimator();
		}
	}
}