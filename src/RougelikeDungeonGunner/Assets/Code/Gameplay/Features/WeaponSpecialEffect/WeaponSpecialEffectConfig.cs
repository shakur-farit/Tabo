using System;
using System.Collections.Generic;
using System.Diagnostics;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Loot
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Weapon Special Effect Config", fileName = "WeaponSpecialEffectConfig")]
	public class WeaponSpecialEffectConfig : ScriptableObject
	{
		public WeaponSpecialEffectTypeId TypeId;
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
		public float MaxParticles;
		public ParticleSystemStopAction StopAction;
		public ParticleSystemCullingMode CullingMode;
	}

	[Serializable]
	public class ParticleSetupEmission
	{
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
		public float Probability;
	}

	[Serializable]
	public class ParticleSetupShape
	{
		public ParticleSystemShapeType Shape;
		public float Angle;
		public float Radius;
	}

	[Serializable]
	public class ParticleSetupVelocityOverLifetime
	{
		public ParticleSystem.MinMaxCurve LinerX;
		public ParticleSystem.MinMaxCurve LinerY;
		public ParticleSystem.MinMaxCurve LinerZ;
	}

	[Serializable]
	public class ParticleSetupColorOverLifetime
	{
		public ParticleSystem.MinMaxGradient Color;
	}

	[Serializable]
	public class ParticleSetupRotationOverLifetime
	{
		public ParticleSystem.MinMaxCurve AngularVelocity;
	}

	[Serializable]
	public class ParticleSetupNoise
	{
		public ParticleSystem.MinMaxCurve Strength;
		public float Frequency;
		public float Octaves;
		public ParticleSystemNoiseQuality Quality;
		public ParticleSystem.MinMaxCurve PositionAmount;
	}

	[Serializable]
	public class ParticleSetupTextureSheetAnimation
	{
		public ParticleSystemAnimationMode Mode;
	}

	[Serializable]
	public class ParticleSetupRenderer
	{
		public Material Material;
		public SortingLayer SortingLayerID;
	}
}