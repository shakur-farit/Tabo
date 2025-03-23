using Code.Gameplay.StaticData;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Weapon.Registrars
{
	public class WeaponFirePositionRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Transform _firePosiotionTransform;

		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(IStaticDataService staticDataService) =>
			_staticDataService = staticDataService;
		public override void RegisterComponents()
		{
			_firePosiotionTransform.localPosition =
				_staticDataService
					.GetWeaponConfig(Entity.WeaponTypeId).FirePosition;

			Entity
				.AddFirePositionTransform(_firePosiotionTransform);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasFirePositionTransform)
				Entity.RemoveFirePositionTransform();
		}
	}
}