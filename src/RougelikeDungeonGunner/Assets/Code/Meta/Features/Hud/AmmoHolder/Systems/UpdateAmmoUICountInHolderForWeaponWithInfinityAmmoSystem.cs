using System.Collections.Generic;
using Entitas;

namespace Code.Meta.UI.AmmoHolder.Systems
{
	public class UpdateAmmoUICountInHolderForWeaponWithInfinityAmmoSystem : ReactiveSystem<GameEntity>
	{
		private const int InfinityMagazineSize = 0;

		private readonly IGroup<GameEntity> _ammoHolders;

		public UpdateAmmoUICountInHolderForWeaponWithInfinityAmmoSystem(Contexts contexts) : base(contexts.game) =>
			_ammoHolders = contexts.game.GetGroup(GameMatcher.AllOf(
				GameMatcher.AmmoHolder));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Weapon,
					GameMatcher.InfinityAmmo)
				.Added());

		protected override bool Filter(GameEntity weapons) =>
			weapons.isWeapon && weapons.isInfinityAmmo;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
			foreach (GameEntity holder in _ammoHolders)
				holder.AmmoHolder.UpdateAmmoUICount(InfinityMagazineSize);
		}
	}
}