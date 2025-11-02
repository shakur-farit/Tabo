using Code.Gameplay.Features.Aura;
using Code.Meta.UI.Windows.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class ApplyShieldRequestSystem : IExecuteSystem
	{
		private readonly IShieldRequestProvider _shieldRequest;
		private readonly IGroup<GameEntity> _hero;

		public ApplyShieldRequestSystem(GameContext game, IShieldRequestProvider shieldRequest)
		{
			_shieldRequest = shieldRequest;
			_hero = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _hero)
			{
				if (_shieldRequest.IsRequiested)
				{
					hero.AddAuraRequest(AuraTypeId.Shield);
					_shieldRequest.IsRequiested = false;
				}
			}
		}
	}
}