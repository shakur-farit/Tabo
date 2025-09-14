using System;
using System.Collections.Generic;
using Code.Infrastructure.View;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.Gameplay.Features.SpecialEffect.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Special Effect Config", fileName = "SpecialEffectConfig")]
	public class SpecialEffectConfig : ScriptableObject
	{
		public SpecialEffectTypeId TypeId;
		public EntityBehaviour ViewPrefab;
		public ParticleSetup ParticleSetup;
	}

	[Serializable]
	public class ParticleSetup
	{
		public ParticleSetupMain Main;
		public ParticleSetupEmission Emission;
		public ParticleSetupShape Shape;
		public ParticleSetupVelocityOverLifetime VelocityOverLifetime;
		public ParticleSetupColorOverLifetime ColorOverLifetime;
		public ParticleSetupRotationOverLifetime RotationOverLifetime;
		public ParticleSetupNoise Noise;
		public ParticleSetupTextureSheetAnimation TextureSheetAnimation;
		public ParticleSetupRenderer Renderer;
	}

	[Serializable]
	public class ParticleSetupMain
	{
		public float Duration;
		public float StartLifetime;
		public float StartSpeed;
		public float StartSize;
		public float GravityModifire;
		public ParticleSystemSimulationSpace SimulationSpace;
		public int MaxParticles;
		public ParticleSystemStopAction StopAction;
		public ParticleSystemCullingMode CullingMode;
	}

	[Serializable]
	public class ParticleSetupEmission
	{
		public bool Enabled;
		public float RateOverTime;
		public List<ParticleEmissionBurst> Bursts;
	}

	[Serializable]
	public class ParticleEmissionBurst
	{
		public float Time;
		public ParticleSystem.MinMaxCurve Count;
		public int Cycles;
		public float Interval;
	}

	[Serializable]
	public class ParticleSetupShape
	{
		public bool Enabled;
		public ParticleSystemShapeType Shape;
		public float Angle;
		public float Radius;
		public float RadiusThickness;
		public ParticleSystemShapeMultiModeValue ArcMode;
		public float ArcSpread;
	}

	[Serializable]
	public class ParticleSetupVelocityOverLifetime
	{
		public bool Enabled;
		public ParticleSystem.MinMaxCurve LinerX;
		public ParticleSystem.MinMaxCurve LinerY;
		public ParticleSystem.MinMaxCurve LinerZ;
		public ParticleSystem.MinMaxCurve SpeedModifier;
	}

	[Serializable]
	public class ParticleSetupColorOverLifetime
	{
		public bool Enabled;
		public ParticleSystem.MinMaxGradient Color;
	}

	[Serializable]
	public class ParticleSetupRotationOverLifetime
	{
		public bool Enabled;
		public ParticleSystem.MinMaxCurve AngularVelocityX;
		public ParticleSystem.MinMaxCurve AngularVelocityY;
		public ParticleSystem.MinMaxCurve AngularVelocityZ;
	}

	[Serializable]
	public class ParticleSetupNoise
	{
		public bool Enabled;
		public ParticleSystem.MinMaxCurve Strength;
		public float Frequency;
		public int Octaves;
		public ParticleSystemNoiseQuality Quality;
		public ParticleSystem.MinMaxCurve PositionAmount;
	}

	[Serializable]
	public class ParticleSetupTextureSheetAnimation
	{
		public bool Enabled;
		public ParticleSystemAnimationMode Mode;
		public List<Sprite> Sprites;
	}

	[Serializable]
	public class ParticleSetupRenderer
	{
		public bool Enabled;
		public Material Material;
	}
}