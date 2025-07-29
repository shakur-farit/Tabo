using Code.Gameplay.StaticData;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Weapon.Registrars
{
	public class HeroCastStartPositionRegistrar : EntityComponentRegistrar
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
					.GetHeroConfig(Entity.HeroTypeId).CastSetup.CastStartPosiotion;

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