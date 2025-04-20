using Code.Gameplay.Features.Loot.Behaviours;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Loot
{
	public class CoinsHolderRegistrar :  EntityComponentRegistrar
	{
		[SerializeField] private CoinsHolder _coinsHolder;

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