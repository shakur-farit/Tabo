using System.Collections.Generic;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class SetWeaponCastStartLocalPositionSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetWeaponCastStartLocalPositionSystem(GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponTypeId,
					GameMatcher.CastStartPositionTransform)
				.Added());
		}

		protected override bool Filter(GameEntity weapons) =>
			weapons.isWeapon && weapons.hasWeaponTypeId && weapons.hasCastStartPositionTransform;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
				weapon.CastStartPositionTransform.localPosition =
					_staticDataService
						.GetWeaponConfig(weapon.WeaponTypeId).CastSetup.CastStartPosiotion;
		}
	}
}