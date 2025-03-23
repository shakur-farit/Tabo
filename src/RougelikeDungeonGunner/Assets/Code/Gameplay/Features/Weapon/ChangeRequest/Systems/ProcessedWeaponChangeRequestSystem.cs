using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Weapon.ChangeRequest.Systems
{
	public class ProcessedWeaponChangeRequestSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _changeRequests;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public ProcessedWeaponChangeRequestSystem(GameContext game)
		{
			_changeRequests = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.WeaponChangeRequested,
					GameMatcher.NewWeaponTypeId));

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
				if(changeRequest.NewWeaponTypeId != weapon.WeaponTypeId)
					changeRequest.isWeaponChangeable = true;

				changeRequest.isProcessed = true;
			}
		}
	}
}