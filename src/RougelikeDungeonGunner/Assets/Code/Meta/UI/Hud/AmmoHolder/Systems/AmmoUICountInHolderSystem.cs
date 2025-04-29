using System.Collections.Generic;
using Entitas;

namespace Code.Meta.UI.Hud.AmmoHolder.Systems
{
	public class AmmoUICountInHolderSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _ammoHolders;

		public AmmoUICountInHolderSystem(Contexts contexts) : base(contexts.game) =>
			_ammoHolders = contexts.game.GetGroup(GameMatcher.AllOf(
				GameMatcher.AmmoHolder));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Weapon,
					GameMatcher.MagazineSize)
				.Added());

		protected override bool Filter(GameEntity weapons) =>
			weapons.isWeapon && weapons.hasMagazineSize;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
			foreach (GameEntity holder in _ammoHolders)
				holder.AmmoHolder.CreateAmmoUI(weapon.MagazineSize);
		}
	}
}