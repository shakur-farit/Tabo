using System.Collections.Generic;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class SetAmmoCastStartLocalPositionSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetAmmoCastStartLocalPositionSystem(GameContext context, IStaticDataService staticDataService) 
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Ammo,
					GameMatcher.AmmoTypeId,
					GameMatcher.CastStartPositionTransform)
				.Added());
		}

		protected override bool Filter(GameEntity ammos) =>
			ammos.isAmmo && ammos.hasAmmoTypeId && ammos.hasCastStartPositionTransform;

		protected override void Execute(List<GameEntity> ammos)
		{
			foreach (GameEntity ammo in ammos)
				ammo.CastStartPositionTransform.localPosition =
					_staticDataService
						.GetAmmoConfig(ammo.AmmoTypeId).CastSetup.CastStartPosiotion;

		}
	}
}