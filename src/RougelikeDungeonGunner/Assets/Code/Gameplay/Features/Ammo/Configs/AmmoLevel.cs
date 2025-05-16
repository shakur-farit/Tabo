using System;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Configs
{
	[Serializable]
	public class AmmoLevel
	{
		[Range(0f, 100f)] public float Speed;
		[Range(0, 100)] public int Pierce = 1;
		[Range(0f, 100f)] public float ContactRadius;
	}
}