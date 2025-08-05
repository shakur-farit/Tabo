using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class RemoveProcessedAmmoFromPatternListSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _patterns;
		private readonly IGroup<GameEntity> _ammo;

		public RemoveProcessedAmmoFromPatternListSystem(GameContext game)
		{
			_patterns = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AmmoTransformsList,
					GameMatcher.Id));

			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.Processed,
					GameMatcher.Transform,
					GameMatcher.AmmoPatternId));
		}

		public void Execute()
		{
			foreach (GameEntity pattern in _patterns)
			foreach (GameEntity ammo in _ammo)
			{
				if (pattern.Id == ammo.AmmoPatternId)
					pattern.AmmoTransformsList.Remove(ammo.Transform);
			}
		}
	}
}