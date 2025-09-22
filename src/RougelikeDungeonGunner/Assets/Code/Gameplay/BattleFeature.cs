using Assets.Code.Common.Destruct;
using Assets.Code.Gameplay.Features.Ammo;
using Assets.Code.Gameplay.Features.AmmoPattern;
using Assets.Code.Gameplay.Features.AStar;
using Assets.Code.Gameplay.Features.Aura;
using Assets.Code.Gameplay.Features.CharacterStats;
using Assets.Code.Gameplay.Features.Collection;
using Assets.Code.Gameplay.Features.Dungeon;
using Assets.Code.Gameplay.Features.EffectApplication;
using Assets.Code.Gameplay.Features.Effects;
using Assets.Code.Gameplay.Features.Enchants;
using Assets.Code.Gameplay.Features.Enemy;
using Assets.Code.Gameplay.Features.Hero;
using Assets.Code.Gameplay.Features.Level;
using Assets.Code.Gameplay.Features.Lifetime;
using Assets.Code.Gameplay.Features.Loot;
using Assets.Code.Gameplay.Features.Movement;
using Assets.Code.Gameplay.Features.Rotation;
using Assets.Code.Gameplay.Features.SpecialEffect;
using Assets.Code.Gameplay.Features.Statuses;
using Assets.Code.Gameplay.Features.Weapon;
using Assets.Code.Gameplay.Input;
using Assets.Code.Infrastructure.Systems;
using Assets.Code.Infrastructure.View;
using Code.Common;

namespace Assets.Code.Gameplay
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
			Add(systems.Create<RotateFeature>());
			Add(systems.Create<WeaponFeature>());
			Add(systems.Create<AmmoPatternFeature>());
			Add(systems.Create<AmmoFeature>());
			Add(systems.Create<SpecialEffectFeature>());

			Add(systems.Create<CollectFeature>());
			Add(systems.Create<EffectApplicationFeature>());

			Add(systems.Create<EnchantFeature>());
			Add(systems.Create<EffectsFeature>());
			Add(systems.Create<StatusFeature>());
			Add(systems.Create<StatsFeature>());
			Add(systems.Create<AuraFeature>());

			Add(systems.Create<ProcessGameDestructedFeature>());
			Add(systems.Create<ProcessInputDestructedFeature>());
		}
	}
}