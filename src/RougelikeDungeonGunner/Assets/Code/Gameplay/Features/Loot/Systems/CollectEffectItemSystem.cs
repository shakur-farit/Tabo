using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Effects.Factory;
using Code.Sounds.SoundEffects.Factory;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectEffectItemSystem : IExecuteSystem
	{
		private readonly IEffectFactory _effectFactory;
		private readonly ISoundEffectFactory _soundEffectFactory;
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _heroes;

		public CollectEffectItemSystem(
			GameContext game, 
			IEffectFactory effectFactory,
			ISoundEffectFactory soundEffectFactory)
		{
			_effectFactory = effectFactory;
			_soundEffectFactory = soundEffectFactory;
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.EffectSetups));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.Id));
		}

		public void Execute()
		{
			foreach (GameEntity collected in _collected)
			foreach (GameEntity hero in _heroes)
			foreach (EffectSetup setup in collected.EffectSetups)
			{
				_effectFactory.CreateEffect(setup, hero.Id, hero.Id);

				if (collected.hasSoundEffectTypeId)
					_soundEffectFactory.CreateSoundEffect(collected.SoundEffectTypeId);
					}
		}
	}
}