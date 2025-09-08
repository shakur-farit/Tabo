using System;
using UnityEngine;

namespace Code.Gameplay.Features.Statuses
{
	[Serializable]
	public class StatusSetup
	{
		public StatusTypeId StatusTypeId;
		[Range(-100f, 100f)] public float Value;
		[Range(0f, 100f)] public float StatusDuration;
		[Range(0f, 100f)] public float Period;
		[Range(0f, 100f)] public float Radius;
	}
}