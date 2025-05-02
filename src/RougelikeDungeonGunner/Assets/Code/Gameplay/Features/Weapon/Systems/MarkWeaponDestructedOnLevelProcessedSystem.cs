using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class MarkWeaponDestructedOnLevelProcessedSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _weapons;

		public MarkWeaponDestructedOnLevelProcessedSystem(GameContext context) : base(context) => 
			_weapons = context.GetGroup(GameMatcher.Weapon);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.Processed.Added());

		protected override bool Filter(GameEntity entity) => entity.isLevel && entity.isProcessed;

		protected override void Execute(List<GameEntity> levels)
		{
			foreach (GameEntity weapon in _weapons) 
				weapon.isDestructed = true;
		}
	}
}