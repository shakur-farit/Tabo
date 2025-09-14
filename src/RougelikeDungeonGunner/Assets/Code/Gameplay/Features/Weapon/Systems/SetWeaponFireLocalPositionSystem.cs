using System.Collections.Generic;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class SetWeaponFireLocalPositionSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetWeaponFireLocalPositionSystem(GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponTypeId,
					GameMatcher.FirePositionTransform)
				.Added());
		}

		protected override bool Filter(GameEntity weapons) =>
			weapons.isWeapon && weapons.hasWeaponTypeId && weapons.hasFirePositionTransform;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
				weapon.FirePositionTransform.localPosition =
					_staticDataService
						.GetWeaponConfig(weapon.WeaponTypeId).FirePosition;
		}
	}
}