using System;
using UnityEngine.Serialization;

namespace Code.Gameplay.Features.Statuses
{
	[Serializable]
	public class StatusSetup
	{
		public StatusTypeId StatusTypeId;
		public float Value;
		public float Duration;
		[FormerlySerializedAs("Preiod")] public float Period;
	}
}