using System.Collections.Generic;
using Code.Gameplay.Features.Levels.Configs;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Levels
{
	[Game] public class LevelTypeIdComponent : IComponent { public LevelTypeId Value; }
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

	[Game] public class EnvironmentSetupAvailable : IComponent { }

	[Game] public class RoomMinPosition : IComponent { public Vector2 Value; }
	[Game] public class RoomMaxPosition : IComponent { public Vector2 Value; }
	[Game] public class HeroStartPosition : IComponent { public Vector2 Value; }
	[Game] public class HeroSafeZoneRadius : IComponent { public float Value; }
}