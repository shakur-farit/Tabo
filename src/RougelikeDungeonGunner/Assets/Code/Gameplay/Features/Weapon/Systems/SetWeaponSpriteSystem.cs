using System.Collections.Generic;
using Assets.Code.Gameplay.StaticData;
using Entitas;

namespace Assets.Code.Gameplay.Features.Weapon.Systems
{
	public class SetWeaponSpriteSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetWeaponSpriteSystem(GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponTypeId,
					GameMatcher.SpriteRenderer)
				.Added());
		}

		protected override bool Filter(GameEntity weapons) =>
			weapons.isWeapon && weapons.hasWeaponTypeId && weapons.hasSpriteRenderer;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
				weapon.SpriteRenderer.sprite =
					_staticDataService
						.GetWeaponConfig(weapon.WeaponTypeId).Sprite;
		}
	}
}