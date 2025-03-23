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
					GameMatcher.WeaponChangeRequested,
					GameMatcher.WeaponChangeable,
					GameMatcher.NewWeaponTypeId));
		}

		public void Execute()
		{
			foreach (GameEntity changeRequest in _changeRequests)
			{
				foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
				{
					Transform parent = weapon.ViewParent;

					weapon.isUnparented = true;

					_weaponFactory.CreateWeapon(changeRequest.NewWeaponTypeId, 1, parent, Vector2.zero);
				}
			}
		}
	}
}