using Code.Progress.Provider;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class CalculateMultiPelletCountSystem : IExecuteSystem
	{
		private readonly IProgressProvider _progressProvider;
		private readonly IGroup<GameEntity> _weapons;

		public CalculateMultiPelletCountSystem(GameContext game, IProgressProvider progressProvider)
		{
			_progressProvider = progressProvider;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.MultiPellet));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
				weapon
					.ReplaceMultiPellet(_progressProvider.WeaponData.PelletCount);
		}
	}
}