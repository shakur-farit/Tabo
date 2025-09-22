using System.Collections.Generic;
using Assets.Code.Gameplay.Features.Aura.Configs;
using Assets.Code.Gameplay.StaticData;
using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Aura.Systems
{
	public class SetAuraColorSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetAuraColorSystem(GameContext context, IStaticDataService staticDataService)
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
			{
				AuraConfig config = _staticDataService.GetAuraConfig(aura.AuraTypeId);

				Color color = aura.SpriteRenderer.color;
				color.a = config.Alpha;
				aura.SpriteRenderer.color = color;
			}
		}
	}
}