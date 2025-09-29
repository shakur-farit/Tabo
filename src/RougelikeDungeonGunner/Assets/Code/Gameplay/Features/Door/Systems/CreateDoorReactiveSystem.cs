using System.Collections.Generic;
using Code.Gameplay.Features.Door.Factory;
using Entitas;

namespace Code.Gameplay.Features.Door.Systems
{
	public class CreateDoorReactiveSystem : ReactiveSystem<GameEntity>
	{
		private readonly IDoorFactory _factory;

		public CreateDoorReactiveSystem(GameContext game, IDoorFactory factory) : base(game) =>
			_factory = factory;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
				GameMatcher.Dungeon,
				GameMatcher.DoorPosition,
				GameMatcher.DoorTypeId).Added());

		protected override bool Filter(GameEntity dungeon) => 
			dungeon.isDungeon && dungeon.hasDoorPosition && dungeon.hasDoorTypeId;

		protected override void Execute(List<GameEntity> dungeons)
		{
			foreach (GameEntity dungeon in dungeons)
				_factory.CreateDoor(dungeon.DoorTypeId, dungeon.DoorPosition);
		}
	}
}