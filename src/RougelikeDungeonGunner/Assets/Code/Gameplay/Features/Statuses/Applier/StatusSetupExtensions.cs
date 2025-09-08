using System;

namespace Code.Gameplay.Features.Statuses.Applier
{
	public static class StatusSetupExtensions
	{
		private const float FloatTolerance = 0.001f;

		public static bool IsIdenticalTo(this StatusSetup setup, GameEntity status)
		{
			if (Math.Abs(status.EffectValue - setup.Value) > FloatTolerance)
				return false;

			if (Math.Abs(status.StatusDuration - setup.StatusDuration) > FloatTolerance)
				return false;

			if (setup.Period > 0)
				return status.hasPeriod && Math.Abs(status.Period - setup.Period) < FloatTolerance;

			return status.hasPeriod == false;
		}
	}
}