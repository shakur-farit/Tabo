using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Weapon.ChangeRequest.Systems
{
	public class ProcessedWeaponChangeRequestSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _changeRequests;
		private readonly IGroup<GameEntity> _weapons;
		private List<GameEntity> _buffer = new(1);

		public ProcessedWeaponChangeRequestSystem(GameContext game)
		{
			_changeRequests = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.WeaponChangeRequest));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponTypeId));
		}

		public void Execute()
		{
			foreach (GameEntity changeRequest in _changeRequests.GetEntities(_buffer))
			foreach (GameEntity weapon in _weapons)
			{
				if(changeRequest.WeaponChangeRequest == weapon.WeaponTypeId)
					continue;

				changeRequest.isNewWeapon = true;
				changeRequest.isProcessed = true;
			}
		}
	}
}