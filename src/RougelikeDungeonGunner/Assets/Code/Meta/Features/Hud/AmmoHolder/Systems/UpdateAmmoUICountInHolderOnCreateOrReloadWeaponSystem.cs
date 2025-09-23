using System.Collections.Generic;
using Entitas;

namespace Code.Meta.Features.Hud.AmmoHolder.Systems
{
	public class UpdateAmmoUICountInHolderOnCreateOrReloadWeaponSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _ammoHolders;

		public UpdateAmmoUICountInHolderOnCreateOrReloadWeaponSystem(Contexts contexts) : base(contexts.game) =>
			_ammoHolders = contexts.game.GetGroup(GameMatcher.AllOf(
				GameMatcher.AmmoHolder));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.HeroWeapon,
					GameMatcher.MagazineNotEmpty,
					GameMatcher.MagazineSize)
				.Added());

		protected override bool Filter(GameEntity weapons) =>
			weapons.isWeapon && weapons.isHeroWeapon && weapons.hasMagazineSize && weapons.isMagazineNotEmpty;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
			foreach (GameEntity holder in _ammoHolders)
				holder.AmmoHolder.UpdateAmmoUICount(weapon.MagazineSize);
		}
	}
}