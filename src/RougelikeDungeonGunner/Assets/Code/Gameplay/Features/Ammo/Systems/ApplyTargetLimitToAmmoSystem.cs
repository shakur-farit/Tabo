using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class ApplyTargetLimitToAmmoSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _weapons;

		public ApplyTargetLimitToAmmoSystem(GameContext context) : base(context)
		{
			_weapons = context.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon, 
					GameMatcher.Pierce));
		}

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Ammo,
					GameMatcher.TargetLimit)
				.Added());
		}

		protected override bool Filter(GameEntity ammunitions) => ammunitions.isAmmo && ammunitions.hasTargetLimit;

		protected override void Execute(List<GameEntity> ammunitions)
		{
			foreach (GameEntity weapon in _weapons.GetEntities())
			foreach (GameEntity ammo in ammunitions)
			{
				ammo.ReplaceTargetLimit(weapon.Pierce);
			}
		}
	}
}