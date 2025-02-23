using Code.Common;
using Code.Gameplay.Features.Hero.Behaviours;
using Code.Gameplay.Features.Movement;
using Code.Gameplay.Input;
using Code.Infrastructure;
using Code.Infrastructure.View;

namespace Code.Gameplay
{
	public sealed class BattleFeature : Feature
	{
		public BattleFeature(ISystemsFactory systems)
		{
			Add(systems.Create<InputFeature>());
			Add(systems.Create<BindViewFeature>());

			Add(systems.Create<HeroFeature>());
			Add(systems.Create<MovementFeature>());

			Add(systems.Create<ProcessDestructedFeature>());
		}
	}
}