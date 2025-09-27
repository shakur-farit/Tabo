using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Registrars
{
	public class EnemyTargetSpriteRendererRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private SpriteRenderer _spriteRenderer;

		public override void RegisterComponents() =>
			Entity.AddEnemyTargetSpriteRenderer(_spriteRenderer);

		public override void UnregisterComponents()
		{
			if (Entity.hasEnemyTargetSpriteRenderer)
				Entity.RemoveEnemyTargetSpriteRenderer();
		}
	}
}