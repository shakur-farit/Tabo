using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Levels
{
	public class MarkWeaponDestructedSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _weapons;

		public MarkWeaponDestructedSystem(GameContext context) : base(context)
		{
			_weapons = context.GetGroup(GameMatcher.Weapon);
		}

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.Processed.Added());

		protected override bool Filter(GameEntity entity) => entity.isLevel;

		protected override void Execute(List<GameEntity> levels)
		{
			foreach (GameEntity weapon in _weapons) 
				weapon.isDestructed = true;
		}
	}
}