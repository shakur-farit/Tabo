using System.Collections.Generic;
using Assets.Code.Gameplay.StaticData;
using Entitas;

namespace Assets.Code.Gameplay.Features.Hero.Systems
{
	public class SetHeroCastStartLocalPositionSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetHeroCastStartLocalPositionSystem(GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Hero,
					GameMatcher.HeroTypeId,
					GameMatcher.CastStartPositionTransform)
				.Added());
		}

		protected override bool Filter(GameEntity heroes) =>
			heroes.isHero && heroes.hasHeroTypeId && heroes.hasCastStartPositionTransform;

		protected override void Execute(List<GameEntity> heroes)
		{
			foreach (GameEntity hero in heroes)
				hero.CastStartPositionTransform.localPosition =
					_staticDataService
						.GetHeroConfig(hero.HeroTypeId).CastSetup.CastStartPosiotion;
		}
	}
}