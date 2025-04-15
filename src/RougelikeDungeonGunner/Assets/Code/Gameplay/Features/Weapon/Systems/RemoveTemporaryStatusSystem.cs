using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Statuses;
using Entitas;
using System.Collections.Generic;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class RemoveTemporaryStatusSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<TemporaryStatusData> _buffer = new();

		public RemoveTemporaryStatusSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.TemporaryStatusSetups));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
				var statuses = weapon.TemporaryStatusSetups;
				_buffer.Clear();

				foreach (var status in statuses)
				{
					var updatedTime = status.Duration - _time.DeltaTime;
					if (updatedTime > 0f)
					{
						_buffer.Add(new TemporaryStatusData(status.Setup, updatedTime));
					}
				}

				if (_buffer.Count > 0)
				{
					weapon.ReplaceTemporaryStatusSetups(new List<TemporaryStatusData>(_buffer));
				}
				else
				{
					weapon.RemoveTemporaryStatusSetups();
				}
			}
		}
	}
}