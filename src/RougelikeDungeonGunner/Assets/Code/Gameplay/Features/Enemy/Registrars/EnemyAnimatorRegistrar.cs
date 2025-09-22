using Assets.Code.Gameplay.Features.Enemy.Behaviours;
using Assets.Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Enemy.Registrars
{
	public class EnemyAnimatorRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private EnemyAnimator _enemyAnimator;

		public override void RegisterComponents()
		{
			Entity
				.AddEnemyAnimator(_enemyAnimator)
				.AddDamageTakenAnimator(_enemyAnimator);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasEnemyAnimator)
				Entity.RemoveEnemyAnimator();

			if (Entity.hasDamageTakenAnimator)
				Entity.RemoveDamageTakenAnimator();
		}
	}
}