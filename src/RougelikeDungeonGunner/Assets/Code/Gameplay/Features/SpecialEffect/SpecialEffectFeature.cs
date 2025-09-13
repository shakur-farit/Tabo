using System;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View;

namespace Code.Gameplay.Features.Loot
{
	public sealed class SpecialEffectFeature : Feature
	{
		public SpecialEffectFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CreateSpecialEffectSystem>());
		}
	}
}