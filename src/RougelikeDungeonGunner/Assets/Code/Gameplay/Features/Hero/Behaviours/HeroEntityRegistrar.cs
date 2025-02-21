using Code.Common.Entity;
using Code.Common.Extensions;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Behaviours
{
	public class HeroEntityRegistrar : MonoBehaviour
	{
		public HeroAnimator HeroAnimator;

		private GameEntity _entity;

		private void Awake()
		{
			_entity = CreateEntity
					.Empty()
					.AddTransform(transform)
					.AddWorldPosition(transform.position)
					.AddSpeed(2)
					.AddDirection(Vector2.zero)
					.AddHeroAnimator(HeroAnimator)
					.With(x => x.isHero = true)
				;
		}
	}
}