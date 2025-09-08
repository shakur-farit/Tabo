using System.Collections.Generic;
using Code.Gameplay.Features.Dungeon;
using Code.Gameplay.Features.Level.Configs;
using Entitas;

namespace Code.Gameplay.Features.Level
{
	[Game] public class LevelTypeIdComponent : IComponent { public LevelTypeId Value; }
	[Game] public class DungeonTypeOnLevel : IComponent { public DungeonTypeId Value; }
	[Game] public class Level : IComponent { }

	[Game] public class StartingTime : IComponent { public float Value; }
	[Game] public class StartingTimeLeft : IComponent { public float Value; }
	[Game] public class StartingTimeUp : IComponent { }
	[Game] public class FinishingTime : IComponent { public float Value; }
	[Game] public class FinishingTimeLeft : IComponent { public float Value; }

	[Game] public class EnemyWaves : IComponent { public List<EnemyWave> Value; }
	[Game] public class EnemyWaveComponent : IComponent { public EnemyWave Value; }
	[Game] public class SpawnedEnemyWaves : IComponent { public int Value; }
	[Game] public class EnemiesInLevelCount : IComponent { public int Value; }
	[Game] public class EnemiesInLevelCountCalculated : IComponent { }

	[Game] public class HeroSafeZoneRadius : IComponent { public float Value; }
}