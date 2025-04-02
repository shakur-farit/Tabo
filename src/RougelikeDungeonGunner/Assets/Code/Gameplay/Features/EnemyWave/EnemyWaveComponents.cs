using Code.Gameplay.Features.Levels.Configs;
using Entitas;

namespace Code.Gameplay.Features.Levels
{
	[Game] public class EnemyWaveComponent : IComponent { public EnemyWave Value; }
	[Game] public class EnemyAmountInWave : IComponent { public int Value; }
}