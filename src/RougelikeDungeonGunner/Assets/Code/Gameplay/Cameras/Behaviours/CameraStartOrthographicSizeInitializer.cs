using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Progress.Data;
using Code.Progress.Provider;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Cameras.Behaviours
{
	public class CameraStartOrthographicSizeInitializer : MonoBehaviour
	{
		private ICameraProvider _cameraProvider;
		private IProgressProvider _progressProvider;

		[Inject]
		public void Constructor(ICameraProvider cameraProvider, IProgressProvider progressProvider)
		{
			_cameraProvider = cameraProvider;
			_progressProvider = progressProvider;
		}

		private void Start()
		{
			WeaponData data = _progressProvider.WeaponData;

			Debug.Log(data.FireRange);

			_cameraProvider.SetCameraSize(data.FireRange);
		}
	}
}