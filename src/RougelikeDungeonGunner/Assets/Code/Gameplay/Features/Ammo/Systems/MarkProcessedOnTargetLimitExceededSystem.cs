using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class MarkProcessedOnTargetLimitExceededSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _ammo;

		public MarkProcessedOnTargetLimitExceededSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.TargetLimit,
					GameMatcher.ProcessedTargets));
		}

		public void Execute()
		{
			foreach (GameEntity ammo in _ammo)
			{
				if (ammo.ProcessedTargets.Count >= ammo.TargetLimit)
					ammo.isProcessed = true;
			}
		}
	}
}