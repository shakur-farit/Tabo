using System;
using UnityEngine.Serialization;

namespace Code.Gameplay.Features.Statuses
{
	[Serializable]
	public struct TemporaryStatusData
	{
		public StatusSetup Setup;
		public float Duration;

		public TemporaryStatusData(StatusSetup setup, float duration)
		{
			Setup = setup;
			Duration = duration;
		}
	}
}