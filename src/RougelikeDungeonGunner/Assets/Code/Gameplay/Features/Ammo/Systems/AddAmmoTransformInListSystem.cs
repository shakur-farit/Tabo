using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class AddAmmoTransformInListSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _ammo;
		private readonly IGroup<GameEntity> _patterns;
		private readonly List<GameEntity> _buffer = new(64);

		public AddAmmoTransformInListSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.AmmoPatternId,
					GameMatcher.Transform)
				.NoneOf(GameMatcher.AddedInList));

			_patterns = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AmmoPattern,
					GameMatcher.AmmoTransformsList,
					GameMatcher.Id));
		}

		public void Execute()
		{
			foreach (GameEntity pattern in _patterns)
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer))
			{
				if (pattern.Id == ammo.AmmoPatternId)
				{
					pattern.AmmoTransformsList.Add(ammo.Transform);
					ammo.isAddedInList = true;
				}
			}
		}
	}
}