using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Door.Systems
{
	public class 
    PlayDoorOpeningAnimationReactiveSystem : ReactiveSystem<GameEntity>
	{
		public PlayDoorOpeningAnimationReactiveSystem(GameContext game) : base(game)
		{
		}

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
				GameMatcher.Door,
				GameMatcher.Opened,
				GameMatcher.DoorAnimator).Added());

		protected override bool Filter(GameEntity door) =>
			door.isDoor && door.hasDoorAnimator && door.isOpened;

		protected override void Execute(List<GameEntity> doors)
		{
			foreach (GameEntity door in doors)
				door.DoorAnimator.PlayOpening();
		}
	}
}