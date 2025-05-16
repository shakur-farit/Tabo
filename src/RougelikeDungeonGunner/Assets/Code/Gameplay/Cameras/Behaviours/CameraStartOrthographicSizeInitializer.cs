using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Cameras.Behaviours
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
			WeaponTypeId weaponId = _staticDataService.GetHeroConfig(HeroTypeId.TheGeneral).StartWeapon;
			WeaponLevel weaponLevel = _staticDataService.GetWeaponLevel(weaponId, 1);

			_cameraProvider.SetCameraSize(weaponLevel.FireRange);
		}
	}
}