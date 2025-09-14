using System.Collections.Generic;
using Code.Gameplay.Features.SpecialEffect.Configs;
using Code.Gameplay.StaticData;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.SpecialEffect.Systems
{
	public class SetupParticleSystemForSpecialEffectSystem : ReactiveSystem<GameEntity>
	{
		private readonly IStaticDataService _staticDataService;

		public SetupParticleSystemForSpecialEffectSystem(GameContext context, IStaticDataService staticDataService)
			: base(context) =>
			_staticDataService = staticDataService;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.SpecialEffect,
					GameMatcher.SpecialEffectTypeId,
					GameMatcher.ParticleSystemRenderer,
					GameMatcher.ParticleSystem)
				.Added());
		}

		protected override bool Filter(GameEntity specialEffects) => 
			specialEffects.isSpecialEffect 
			&& specialEffects.hasSpecialEffectTypeId 
			&& specialEffects.hasParticleSystem
			&& specialEffects.hasParticleSystemRenderer;

		protected override void Execute(List<GameEntity> specialEffects)
		{
			foreach (GameEntity specialEffect in specialEffects)
			{
				specialEffect.ParticleSystem.Stop();

				SetupParticleSystem(
					specialEffect.ParticleSystem,
					specialEffect.ParticleSystemRenderer,
					_staticDataService.GetSpecialEffectConfig(specialEffect.SpecialEffectTypeId));

				specialEffect.ParticleSystem.Play();
			}
		}

		private void SetupParticleSystem(ParticleSystem particleSystem, 
			ParticleSystemRenderer particleSystemRenderer, SpecialEffectConfig config)
		{
			ParticleSetup setup = config.ParticleSetup;

			SetupMainModule(particleSystem, setup);
			SetupEmissionModule(particleSystem, setup);
			SetupShapeModule(particleSystem,setup);
			SetupVelocityOverLifetimeModule(particleSystem, setup);
			SetupLimitVelocityOverLifetimeModule(particleSystem, setup);
			SetupColorOverLifetimeModule(particleSystem, setup);
			SetupSizeOverLifetimeModule(particleSystem, setup);
			SetupRotationOverLifetimeModule(particleSystem,setup);
			SetupNoiseModule(particleSystem,setup);
			SetupTextureSheetAnimationModule(particleSystem,setup);
			SetupRendererModule(particleSystemRenderer, setup);
		}

		private void SetupMainModule(ParticleSystem particleSystem, ParticleSetup setup)
		{
			ParticleSystem.MainModule systemMain = particleSystem.main;
			ParticleSetupMain setupMain = setup.Main;

			systemMain.duration = setupMain.Duration;
			systemMain.startLifetime = setupMain.StartLifetime;
			systemMain.startSpeed = setupMain.StartSpeed;
			systemMain.startSize = setupMain.StartSize;
			systemMain.gravityModifier = setupMain.GravityModifire;
			systemMain.simulationSpace  = setupMain.SimulationSpace;
			systemMain.maxParticles = setupMain.MaxParticles;
			systemMain.stopAction = setupMain.StopAction;
			systemMain.cullingMode = setupMain.CullingMode;
		}

		private void SetupEmissionModule(ParticleSystem particleSystem, ParticleSetup setup)
		{
			ParticleSystem.EmissionModule systemEmission = particleSystem.emission;
			ParticleSetupEmission setupEmission = setup.Emission;

			systemEmission.enabled = setupEmission.Enabled;
			systemEmission.rateOverTime = setupEmission.RateOverTime;

			if (setupEmission.Bursts == null || setupEmission.Bursts.Count == 0)
				return;

			ParticleSystem.Burst[] bursts = new ParticleSystem.Burst[setupEmission.Bursts.Count];

			for (int i = 0; i < setupEmission.Bursts.Count; i++)
			{
				ParticleEmissionBurst src = setupEmission.Bursts[i];

				bursts[i] = new ParticleSystem.Burst(src.Time, src.Count, src.Cycles,src.Interval);
			}

			systemEmission.SetBursts(bursts);
		}

		private void SetupShapeModule(ParticleSystem particleSystem, ParticleSetup setup)
		{
			ParticleSystem.ShapeModule systemShape = particleSystem.shape;
			ParticleSetupShape setupShape = setup.Shape;

			systemShape.enabled = setupShape.Enabled;
			systemShape.shapeType = setupShape.Shape;
			systemShape.angle = setupShape.Angle;
			systemShape.radius = setupShape.Radius;
			systemShape.radiusThickness = setupShape.RadiusThickness;
			systemShape.arcMode = setupShape.ArcMode;
			systemShape.arcSpread = setupShape.ArcSpread;
		}

		private void SetupVelocityOverLifetimeModule(ParticleSystem particleSystem, ParticleSetup setup)
		{
			ParticleSystem.VelocityOverLifetimeModule systemVelocityOverLifetime = particleSystem.velocityOverLifetime;
			ParticleSetupVelocityOverLifetime setupVelocityOverLifetime = setup.VelocityOverLifetime;

			systemVelocityOverLifetime.enabled = setupVelocityOverLifetime.Enabled;
			systemVelocityOverLifetime.x = setupVelocityOverLifetime.LinerX;
			systemVelocityOverLifetime.y = setupVelocityOverLifetime.LinerY;
			systemVelocityOverLifetime.z = setupVelocityOverLifetime.LinerZ;
			systemVelocityOverLifetime.speedModifier = setupVelocityOverLifetime.SpeedModifier;
		}

		private void SetupLimitVelocityOverLifetimeModule(ParticleSystem particleSystem, ParticleSetup setup)
		{
			ParticleSystem.LimitVelocityOverLifetimeModule systemLimitVelocityOverLifetime = particleSystem.limitVelocityOverLifetime;
			ParticleSetupLimitVelocityOverLifetime setupLimitVelocityOverLifetime = setup.LimitVelocityOverLifetime;

			systemLimitVelocityOverLifetime.enabled = setupLimitVelocityOverLifetime.Enabled;
			systemLimitVelocityOverLifetime.limit = setupLimitVelocityOverLifetime.Speed;
			systemLimitVelocityOverLifetime.dampen = setupLimitVelocityOverLifetime.Dampen;
			systemLimitVelocityOverLifetime.drag = setupLimitVelocityOverLifetime.Drag;

		}

		private void SetupColorOverLifetimeModule(ParticleSystem particleSystem, ParticleSetup setup)
		{
			ParticleSystem.ColorOverLifetimeModule systemColorOverLifetime = particleSystem.colorOverLifetime;
			ParticleSetupColorOverLifetime setupColorOverLifetime = setup.ColorOverLifetime;

			systemColorOverLifetime.enabled = setupColorOverLifetime.Enabled;
			systemColorOverLifetime.color = setupColorOverLifetime.Color;
		}

		private void SetupSizeOverLifetimeModule(ParticleSystem particleSystem, ParticleSetup setup)
		{
			ParticleSystem.SizeOverLifetimeModule systemSizeOverLifetime = particleSystem.sizeOverLifetime;
			ParticleSetupSizeOverLifetime setupSizeOverLifetime = setup.SizeOverLifetime;

			systemSizeOverLifetime.enabled = setupSizeOverLifetime.Enabled;
			systemSizeOverLifetime.size = setupSizeOverLifetime.Size;
		}

		private void SetupRotationOverLifetimeModule(ParticleSystem particleSystem, ParticleSetup setup)
		{
			ParticleSystem.RotationOverLifetimeModule systemRotationOverLifetime = particleSystem.rotationOverLifetime;
			ParticleSetupRotationOverLifetime setupRotationOverLifetime = setup.RotationOverLifetime;

			systemRotationOverLifetime.enabled = setupRotationOverLifetime.Enabled;
			systemRotationOverLifetime.z = setupRotationOverLifetime.AngularVelocity;
		}

		private void SetupNoiseModule(ParticleSystem particleSystem, ParticleSetup setup)
		{
			ParticleSystem.NoiseModule systemNoise = particleSystem.noise;
			ParticleSetupNoise setupNoise = setup.Noise;

			systemNoise.enabled = setupNoise.Enabled;
			systemNoise.strength = setupNoise.Strength;
			systemNoise.frequency = setupNoise.Frequency;
			systemNoise.scrollSpeed = setupNoise.ScrollSpeed;
			systemNoise.damping = setupNoise.Damping;
			systemNoise.octaveCount = setupNoise.Octaves;
			systemNoise.octaveScale = setupNoise.OctavesScale;
			systemNoise.quality = setupNoise.Quality;
			systemNoise.positionAmount = setupNoise.PositionAmount;
			systemNoise.rotationAmount = setupNoise.RotationAmount;
			systemNoise.sizeAmount = setupNoise.SizeAmount;
		}

		private void SetupTextureSheetAnimationModule(ParticleSystem particleSystem, ParticleSetup setup)
		{
			ParticleSystem.TextureSheetAnimationModule systemTextureSheetAnimation = particleSystem.textureSheetAnimation;
			ParticleSetupTextureSheetAnimation setupTextureSheetAnimation = setup.TextureSheetAnimation;

			systemTextureSheetAnimation.enabled = setupTextureSheetAnimation.Enabled;
			systemTextureSheetAnimation.mode = setupTextureSheetAnimation.Mode;

			for(int i = 0; i < setupTextureSheetAnimation.Sprites.Count; i++)
				systemTextureSheetAnimation.SetSprite(i, setupTextureSheetAnimation.Sprites[i]);
		}

		private void SetupRendererModule(ParticleSystemRenderer particleSystemRenderer, ParticleSetup setup)
		{
			particleSystemRenderer.enabled = setup.Renderer.Enabled;
			particleSystemRenderer.material = setup.Renderer.Material;
		}
	}
}