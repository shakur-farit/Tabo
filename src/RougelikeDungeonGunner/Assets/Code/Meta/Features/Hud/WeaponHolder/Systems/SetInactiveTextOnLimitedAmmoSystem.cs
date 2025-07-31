using System.Collections.Generic;
using Entitas;

namespace Code.Meta.Features.Hud.WeaponHolder.Systems
{
	public class SetInactiveTextOnLimitedAmmoSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _weaponHolders;

		public SetInactiveTextOnLimitedAmmoSystem(Contexts contexts) : base(contexts.game) =>
			_weaponHolders = contexts.game.GetGroup(GameMatcher.AllOf(
				GameMatcher.WeaponHolder));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Weapon,
					GameMatcher.HeroWeapon,
					GameMatcher.MagazineSize)
				.Added());

		protected override bool Filter(GameEntity weapons) =>
			weapons.isWeapon && weapons.hasMagazineSize;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
			foreach (GameEntity holder in _weaponHolders)
				holder.WeaponHolder.SetInactiveOnInfinityAmmo();
		}
	}
}