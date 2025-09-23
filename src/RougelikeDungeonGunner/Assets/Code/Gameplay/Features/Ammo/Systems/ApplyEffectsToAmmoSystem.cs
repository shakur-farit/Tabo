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
					GameMatcher.Ammo,
					GameMatcher.ProducerId)
				.NoneOf(GameMatcher.EffectSetups));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.Id,
					GameMatcher.EffectSetups));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer))
				if (weapon.Id == ammo.ProducerId)
					ammo.AddEffectSetups(new(weapon.EffectSetups));
			// To avoid errors when modifying the list in the future,
			// you should create new ones using new instead of directly copying.
		}
	}
}