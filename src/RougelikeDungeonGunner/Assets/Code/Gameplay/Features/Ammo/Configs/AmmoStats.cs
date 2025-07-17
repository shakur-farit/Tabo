using System;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Configs
{
	[Serializable]
	public class AmmoStats
	{
		[Range(0f, 100f)] public float Speed;
		[Range(0f, 100f)] public float ContactRadius;
		[Range(0f, 100f)] public float ForwardCastDistance;
		[Range(0f, 100f)] public float CastOriginOffset;
	}
}