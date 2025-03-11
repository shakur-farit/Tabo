using System;

namespace Code.Gameplay.Features.Effects
{
	[Serializable]
	public class EffectSetup
	{
		public EffectTypeId EffectTypeId;
		public float Value;

		public static EffectSetup FormId(EffectTypeId typeId, float value) =>
			new() { EffectTypeId = typeId, Value = value };
	}
}