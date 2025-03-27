using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Cameras.Systems
{
	public class ChangeCameraSizeDependingOnWeaponTypeSystem : IExecuteSystem
	{
		private readonly ICameraProvider _camera;
		private readonly IStaticDataService _staticDataService;
		private readonly IGroup<GameEntity> _requests;

		public ChangeCameraSizeDependingOnWeaponTypeSystem(
			GameContext game, 
			ICameraProvider camera,
			IStaticDataService staticDataService)
		{
			_camera = camera;
			_staticDataService = staticDataService;
			_requests = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.WeaponChangeable,
					GameMatcher.NewWeaponTypeId));
		}

		public void Execute()
		{
			foreach (GameEntity request in _requests)
			{
				WeaponLevel level = _staticDataService.GetWeaponLevel(request.NewWeaponTypeId, 1);

				_camera.SetCameraSize(level.FireRange);
			}
		}
	}
}