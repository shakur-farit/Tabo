using System.Collections.Generic;
using Code.Gameplay.StaticData;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Loot
{
	public class SetupSpecialEffectSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetupSpecialEffectSystem(GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.SpecialEffect,
					GameMatcher.SpecialEffectTypeId,
					GameMatcher.ParticleSystem)
				.Added());
		}

		protected override bool Filter(GameEntity specialEffects) => 
			specialEffects.isSpecialEffect && specialEffects.hasSpecialEffectTypeId && specialEffects.hasParticleSystem;

		protected override void Execute(List<GameEntity> specialEffects)
		{
			foreach (GameEntity specialEffect in specialEffects)
				SetupParticleSystem(
					specialEffect.ParticleSystem, 
					_staticDataService.GetSpecialEffectConfig(specialEffect.SpecialEffectTypeId));
		}

		private void SetupParticleSystem(ParticleSystem particleSystem, SpecialEffectConfig config)
		{
			ParticleSetup setup = config.ParticleSetup;

			SetupMainModule(particleSystem, setup);
		}

		private static void SetupMainModule(ParticleSystem particleSystem, ParticleSetup setup)
		{
			ParticleSystem.MainModule systemMain = particleSystem.main;
			ParticleSetupMain setupMain = setup.Main;

			systemMain.duration = setupMain.Duration;
		}
	}
}