using System;

namespace Code.Gameplay.Features.Statuses
{
	[Serializable]
	public class StatusSetup
	{
		public StatusTypeId StatusTypeId;
		public float Value;
		public float StatusDuration;
		public float Period;
	}
}