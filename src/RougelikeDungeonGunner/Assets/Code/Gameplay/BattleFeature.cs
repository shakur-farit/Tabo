using Code.Common;
using Code.Gameplay.Features.Ammo;
using Code.Gameplay.Features.AmmoPattern;
using Code.Gameplay.Features.AStar;
using Code.Gameplay.Features.CharacterStats;
using Code.Gameplay.Features.Dungeon;
using Code.Gameplay.Features.EffectApplication;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Enchants;
using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Level;
using Code.Gameplay.Features.Lifetime;
using Code.Gameplay.Features.Loot;
using Code.Gameplay.Features.Movement;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.TargetCollection;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Input;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View;

namespace Code.Gameplay
{
	public sealed class BattleFeature : Feature
	{
		public BattleFeature(ISystemsFactory systems)
		{
			Add(systems.Create<InputFeature>());
			Add(systems.Create<LevelFeature>());
			Add(systems.Create<DungeonFeature>());
			Add(systems.Create<BindViewFeature>());

			Add(systems.Create<PathfindingFeature>());

			Add(systems.Create<HeroFeature>());
			Add(systems.Create<EnemyFeature>());
			Add(systems.Create<DeathFeature>());

			Add(systems.Create<LootFeature>());

			Add(systems.Create<MovementFeature>());
			Add(systems.Create<WeaponFeature>());
			Add(systems.Create<AmmoPatternFeature>());
			Add(systems.Create<AmmoFeature>());

			Add(systems.Create<CollectTargetsFeature>());
			Add(systems.Create<EffectApplicationFeature>());

			Add(systems.Create<EnchantFeature>());
			Add(systems.Create<EffectsFeature>());
			Add(systems.Create<StatusFeature>());
			Add(systems.Create<StatsFeature>());

			Add(systems.Create<ProcessGameDestructedFeature>());
			Add(systems.Create<ProcessInputDestructedFeature>());
		}
	}
}