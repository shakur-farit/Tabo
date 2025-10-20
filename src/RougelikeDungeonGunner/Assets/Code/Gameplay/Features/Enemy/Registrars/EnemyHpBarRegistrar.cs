using Code.Gameplay.Features.Enemy.Behaviours;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Registrars
{
	public class EnemyHpBarRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private EnemyHpBar _hpBar;

		public override void RegisterComponents() =>
			Entity.AddEnemyHpBar(_hpBar);

		public override void UnregisterComponents()
		{
			if (Entity.hasEnemyHpBar)
				Entity.RemoveEnemyHpBar();
		}
	}
}