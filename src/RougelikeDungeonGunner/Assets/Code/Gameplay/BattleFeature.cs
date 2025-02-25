using Code.Common;
using Code.Gameplay.Features.DamageApplication;
using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Movement;
using Code.Gameplay.Features.TargetCollection;
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
			Add(systems.Create<EnemyFeature>());

			Add(systems.Create<MovementFeature>());

			Add(systems.Create<CollectTargetsFeature>());
			Add(systems.Create<DamageApplicationFeature>());

			Add(systems.Create<ProcessDestructedFeature>());
		}
	}
}