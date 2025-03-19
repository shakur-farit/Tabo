using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class SetupRuntimeAnimatorControllerForTheGeneralSystem : IExecuteSystem
	{
		private readonly IStaticDataService _staticDataService;
		private readonly IGroup<GameEntity> _heroes;

		public SetupRuntimeAnimatorControllerForTheGeneralSystem(GameContext game, IStaticDataService staticDataService)
		{
			_staticDataService = staticDataService;
			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.TheGeneral,
					GameMatcher.HeroAnimator));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			{
				var config = _staticDataService.GetHeroConfig(HeroTypeId.TheGeneral);

				hero.HeroAnimator.SetRuntimeAnimatorController(config.AnimatorController);
			}
		}
	}
}