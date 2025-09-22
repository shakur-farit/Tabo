using Assets.Code.Infrastructure.View.Registrars;
using Assets.Code.Meta.Features.Hud.CoinsHolder.Behaviours;
using UnityEngine;

namespace Assets.Code.Meta.Features.Hud.CoinsHolder.Registrar
{
	public class CoinsHolderRegistrar :  EntityComponentRegistrar
	{
		[SerializeField] private CoinsHolderBehaviour _coinsHolder;

		public override void RegisterComponents() =>
			Entity.AddCoinsHolder(_coinsHolder);

		public override void UnregisterComponents()
		{
			if(Entity.hasCoinsHolder)
				Entity.RemoveCoinsHolder();
		}
	}
}