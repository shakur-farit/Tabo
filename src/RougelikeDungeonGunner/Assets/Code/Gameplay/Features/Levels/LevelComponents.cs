using System.Collections.Generic;
using Code.Gameplay.Features.Levels.Configs;
using Entitas;

namespace Code.Gameplay.Features.Levels
{
	[Game] public class LevelTypeIdComponent : IComponent { public LevelTypeId Value; }

	[Game] public class StartingTime : IComponent { public float Value; }
	[Game] public class StartingTimeLeft : IComponent { public float Value; }
	[Game] public class TimeBetweenWaves : IComponent { public float Value; }
	[Game] public class TimeBetweenWavesLeft : IComponent { public float Value; }
	[Game] public class FinishingTime : IComponent { public float Value; }
	[Game] public class FinishingTimeLeft : IComponent { public float Value; }

	[Game] public class EnemyWaves : IComponent { public List<EnemyWave> Value; }
	[Game] public class CreatedEnemyWavesAmount : IComponent { public int Value; }
	[Game] public class WaveAvailable : IComponent { }
}