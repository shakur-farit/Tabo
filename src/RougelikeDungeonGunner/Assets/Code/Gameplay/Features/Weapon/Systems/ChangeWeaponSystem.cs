using System.Collections.Generic;
using Code.Gameplay.Features.Weapon.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class ChangeWeaponSystem : IExecuteSystem
	{
		private readonly IWeaponFactory _weaponFactory;
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _changeRequests;
		private readonly List<GameEntity> _buffer = new(1);
		private readonly List<GameEntity> _weaponBuffer = new(4);

		public ChangeWeaponSystem(
			GameContext game, 
			IWeaponFactory weaponFactory)
		{
			_weaponFactory = weaponFactory;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon));

			_changeRequests = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.WeaponChangeRequest,
					GameMatcher.NewWeapon,
					GameMatcher.ReadyToChangeWeapon));
		}

		public void Execute()
		{
			foreach (GameEntity changeRequest in _changeRequests.GetEntities(_buffer))
			{
				foreach (GameEntity weapon in _weapons.GetEntities(_weaponBuffer))
				{
					Transform parent = weapon.ViewParent;

					weapon.isUnparented = true;

					_weaponFactory.CreateWeapon(changeRequest.WeaponChangeRequest, 1, parent, Vector2.zero);
				}

				changeRequest.isReadyToChangeWeapon = false;
			}
		}
	}
}