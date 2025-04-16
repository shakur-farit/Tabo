using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class ApplyEffectsToAmmoSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _ammo;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(32);

		public ApplyEffectsToAmmoSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo)
				.NoneOf(GameMatcher.EffectSetups));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.EffectSetups));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer))
				ammo.AddEffectSetups(weapon.EffectSetups);
		}
	}
}