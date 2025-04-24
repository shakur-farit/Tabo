using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class ApplyEnchantVisualsToAmmoReactiveSystem : ReactiveSystem<GameEntity>
	{
		public ApplyEnchantVisualsToAmmoReactiveSystem(GameContext context) : base(context)
		{

		} 

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
				GameMatcher.StatusSetups,
				GameMatcher.EnchantVisualEffect)
				.Added());
		}

		protected override bool Filter(GameEntity entity) => entity.hasStatusSetups && entity.hasEnchantVisualEffect;

		protected override void Execute(List<GameEntity> entities)
		{
			foreach (GameEntity ammo in entities)
			foreach (StatusSetup setup in ammo.StatusSetups)
			{
				Debug.Log(setup.StatusTypeId);

					ammo.EnchantVisualEffect.ApplyVisual(setup.StatusTypeId);
			}
		}
	}
}