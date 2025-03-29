using Code.Gameplay.Features.Hero;
using Code.Gameplay.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Cameras.Provider
{
	public class CameraStartOrthographicSizeInitializer : MonoBehaviour
	{
		private IStaticDataService _staticDataService;
		private ICameraProvider _cameraProvider;

		[Inject]
		public void Constructor(IStaticDataService staticDataService, ICameraProvider cameraProvider)
		{
			_staticDataService = staticDataService;
			_cameraProvider = cameraProvider;
		}

		private void Start()
		{
			var weaponId = _staticDataService.GetHeroConfig(HeroTypeId.TheGeneral).StartWeapon;
			var weaponLevel = _staticDataService.GetWeaponLevel(weaponId, 1);

			_cameraProvider.SetCameraSize(weaponLevel.FireRange);
		}
	}
}