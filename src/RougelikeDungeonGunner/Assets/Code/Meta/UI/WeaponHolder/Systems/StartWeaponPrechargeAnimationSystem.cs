using System.Collections.Generic;
using Entitas;

namespace Code.Meta.UI.WeaponHolder.Systems
{
	public class StartWeaponPrechargeAnimationSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _reloadingAnimator;

		public StartWeaponPrechargeAnimationSystem(Contexts contexts) : base(contexts.game) =>
			_reloadingAnimator = contexts.game.GetGroup(GameMatcher.AllOf(
				GameMatcher.ReloadingAnimator));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Weapon,
					GameMatcher.PrechargeTime,
					GameMatcher.PrechargeTimeLeft,
					GameMatcher.ReadyToShoot)
				.Added());

		protected override bool Filter(GameEntity weapons) =>
			weapons.isWeapon && weapons.hasPrechargeTime && weapons.hasPrechargeTimeLeft && weapons.isReadyToShoot
			&& weapons.isPrecharged == false;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
			foreach (GameEntity animator in _reloadingAnimator)
				animator.ReloadingAnimator.AnimatePrecharging(weapon.PrechargeTimeLeft, weapon.PrechargeTime);
		}
	}
}