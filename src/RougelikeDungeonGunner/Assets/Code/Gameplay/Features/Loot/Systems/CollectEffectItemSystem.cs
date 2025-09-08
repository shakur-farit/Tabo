﻿using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Effects.Factory;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectEffectItemSystem : IExecuteSystem
	{
		private readonly IEffectFactory _effectFactory;
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _heroes;

		public CollectEffectItemSystem(GameContext game, IEffectFactory effectFactory)
		{
			_effectFactory = effectFactory;
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
				_effectFactory.CreateEffect(setup, hero.Id, hero.Id);
		}
	}
}