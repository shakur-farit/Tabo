using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class SetupRuntimeAnimatorControllerForOrcSystem : IExecuteSystem
	{
		private readonly IStaticDataService _staticDataService;
		private readonly IGroup<GameEntity> _orcs;

		public SetupRuntimeAnimatorControllerForOrcSystem(GameContext game, IStaticDataService staticDataService)
		{
			_staticDataService = staticDataService;
			_orcs = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Orc,
					GameMatcher.EnemyAnimator));
		}

		public void Execute()
		{
			foreach (GameEntity orc in _orcs)
			{
				var config = _staticDataService.GetEnemyConfig(EnemyTypeId.Orc);

				orc.EnemyAnimator.SetRuntimeAnimatorController(config.AnimatorController);
			}
		}
	}
}