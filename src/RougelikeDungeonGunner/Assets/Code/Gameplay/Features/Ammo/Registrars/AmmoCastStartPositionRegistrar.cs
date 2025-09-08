using Code.Gameplay.StaticData;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Ammo.Registrars
{
	public class AmmoCastStartPositionRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Transform _startPosiotionTransform;

		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(IStaticDataService staticDataService) =>
			_staticDataService = staticDataService;
		public override void RegisterComponents()
		{
			_startPosiotionTransform.localPosition =
				_staticDataService
					.GetAmmoConfig(Entity.AmmoTypeId).CastSetup.CastStartPosiotion;

			Entity
				.AddCastStartPositionTransform(_startPosiotionTransform);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasCastStartPositionTransform)
				Entity.RemoveCastStartPositionTransform();
		}
	}
}