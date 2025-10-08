using System.Collections.Generic;
using Code.Gameplay.Features.Music;
using Code.Sounds.SoundEffects.Factory;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectShieldItemSystem : IExecuteSystem
	{
		private readonly ISoundEffectFactory _soundEffectFactory;
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _heroes;
		private readonly List<GameEntity> _buffer = new(1);

		public CollectShieldItemSystem(GameContext game, ISoundEffectFactory soundEffectFactory)
		{
			_soundEffectFactory = soundEffectFactory;
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.Shield));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero)
				.NoneOf(GameMatcher.ShieldApplied));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes.GetEntities(_buffer))
			foreach (GameEntity collected in _collected)
			{
				hero.isRequestShield = collected.isShield;

				if (collected.hasSoundEffectTypeId)
					_soundEffectFactory.CreateSoundEffect(collected.SoundEffectTypeId);
				}
		}
	}
}