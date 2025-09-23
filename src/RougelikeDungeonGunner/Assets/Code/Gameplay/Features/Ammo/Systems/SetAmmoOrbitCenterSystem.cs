using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class SetAmmoOrbitCenterSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _ammo;
		private readonly IGroup<GameEntity> _patterns;

		public SetAmmoOrbitCenterSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.AmmoPatternId,
					GameMatcher.OrbitCenter));

			_patterns = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AmmoPattern,
					GameMatcher.Id,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity pattern in _patterns)
			foreach (GameEntity ammo in _ammo)
			{
				if (pattern.Id == ammo.AmmoPatternId)
					ammo.ReplaceOrbitCenter(pattern.WorldPosition);
			}
		}
	}
}