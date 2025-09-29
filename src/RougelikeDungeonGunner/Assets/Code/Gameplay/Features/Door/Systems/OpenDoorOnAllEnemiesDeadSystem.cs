using System.Collections.Generic;
using Code.Gameplay.Features.Music;
using Entitas;

namespace Code.Gameplay.Features.Door.Systems
{
	public class OpenDoorOnAllEnemiesDeadSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IMusicClipSetter _clipSetter;
		private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _doors;

		public OpenDoorOnAllEnemiesDeadSystem(GameContext game, IMusicClipSetter clipSetter)
		{
			_clipSetter = clipSetter;
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemiesInLevelCount));

			_doors = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Door));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
			foreach (GameEntity door in _doors.GetEntities(_buffer))
				if (level.EnemiesInLevelCount <= 0)
				{
					door.isOpened = true;
					_clipSetter.SetClip(MusicTypeId.ClearedRoom);
				}
		}
	}
}