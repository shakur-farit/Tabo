using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class RemoveTemporaryStatusSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _weapons;

		public RemoveTemporaryStatusSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon
					//GameMatcher.TemporaryStatusSetups
					));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
			}
		}
	}
}