using System.Collections.Generic;
using Code.Gameplay.Features.Hero.Configs;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class SetHeroRuntimeAnimatorControllerSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetHeroRuntimeAnimatorControllerSystem(
			GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Hero,
					GameMatcher.HeroTypeId,
					GameMatcher.HeroAnimator)
				.Added());
		}

		protected override bool Filter(GameEntity heroes) =>
			heroes.isHero
			&& heroes.hasHeroTypeId
			&& heroes.hasHeroAnimator;

		protected override void Execute(List<GameEntity> heroes)
		{
			foreach (GameEntity hero in heroes)
			{
				HeroConfig config = _staticDataService.GetHeroConfig(hero.HeroTypeId);

				hero.HeroAnimator.SetRuntimeAnimatorController(config.AnimatorController);
			}
		}
	}
}