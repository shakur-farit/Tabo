using System;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Configs
{
	[Serializable]
	public class AmmoStats
	{
		[Range(0f, 100f)] public float ContactRadius;
	}
}