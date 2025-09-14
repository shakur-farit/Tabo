using System.Collections.Generic;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Aura.Systems
{
	public class SetAuraSpriteSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetAuraSpriteSystem(GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Aura,
					GameMatcher.AuraTypeId,
					GameMatcher.SpriteRenderer)
				.Added());
		}

		protected override bool Filter(GameEntity auras) =>
			auras.isAura && auras.hasAuraTypeId && auras.hasSpriteRenderer;

		protected override void Execute(List<GameEntity> auras)
		{
			foreach (GameEntity aura in auras)
				aura.SpriteRenderer.sprite =
					_staticDataService
						.GetAuraConfig(aura.AuraTypeId).Sprite;
		}
	}
}