using Code.Gameplay.Features.Hero.Services;
using Code.Sounds.SoundEffects.Factory;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectCoinsSystem : IExecuteSystem
	{
    private readonly ICoinService _coinService;
    private readonly ISoundEffectFactory _soundEffectFactory;
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _heroes;

		public CollectCoinsSystem(
      GameContext game, 
      ICoinService coinService, 
      ISoundEffectFactory soundEffectFactory)
		{
      _coinService = coinService;
      _soundEffectFactory = soundEffectFactory;
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.LootValue,
					GameMatcher.Coins));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.CurrentCoins));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity collected in _collected)
			{
				hero.ReplaceCurrentCoins(hero.CurrentCoins + collected.LootValue);

				_coinService.SetCurrentCoinCount(hero.CurrentCoins);

				if (collected.hasSoundEffectTypeId)
					_soundEffectFactory.CreateSoundEffect(collected.SoundEffectTypeId);
			}
		}
	}
}