using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Meta.UI.Hud.CoinsHolder.Registrar
{
	public class CoinsHolderRegistrar :  EntityComponentRegistrar
	{
		[SerializeField] private Behaviours.CoinsHolderBehaviour _coinsHolder;

		public override void RegisterComponents() =>
			Entity
				.AddCoinsHolder(_coinsHolder);

		public override void UnregisterComponents()
		{
			if(Entity.hasCoinsHolder)
				Entity.RemoveCoinsHolder();
		}
	}
}