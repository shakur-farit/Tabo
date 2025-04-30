using System.Collections.Generic;
using Entitas;

namespace Code.Meta.UI.Hud.WeaponHolder.Systems
{
	public class StartWeaponReloadingAnimationSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _reloadingAnimator;

		public StartWeaponReloadingAnimationSystem(Contexts contexts) : base(contexts.game) =>
			_reloadingAnimator = contexts.game.GetGroup(GameMatcher.AllOf(
				GameMatcher.ReloadingAnimator));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Weapon,
					GameMatcher.ReloadTimeLeft,
					GameMatcher.Reloading)
				.Added());

		protected override bool Filter(GameEntity weapons) =>
			weapons.isWeapon && weapons.isReloading && weapons.hasReloadTimeLeft;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
			foreach (GameEntity animator in _reloadingAnimator)
				animator.ReloadingAnimator.AnimateReloading(weapon.ReloadTimeLeft, weapon.ReloadTime);
		}
	}
}