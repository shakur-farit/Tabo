using Assets.Code.Gameplay.Cameras.Provider;
using Code.Common.Extensions;
using Entitas;

namespace Assets.Code.Gameplay.Cameras.Systems
{
	public class CameraFollowHeroSystem : IExecuteSystem
	{
		private readonly ICameraProvider _cameraProvider;
		private readonly IGroup<GameEntity> _heroes;

		public CameraFollowHeroSystem(GameContext game, ICameraProvider cameraProvider)
		{
			_cameraProvider = cameraProvider;
			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
				_cameraProvider.MainCamera.transform.SetWorldXY(hero.WorldPosition.x, hero.WorldPosition.y);
		}
	}
}