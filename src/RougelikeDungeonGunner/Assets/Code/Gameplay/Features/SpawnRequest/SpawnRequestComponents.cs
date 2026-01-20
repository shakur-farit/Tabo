using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	[Game] public class SpawnRequest : IComponent { }
	[Game] public class SpawnRequestTypeIdComponent : IComponent { public SpawnRequestTypeId Value; }
	[Game] public class SpawnPosition : IComponent { public Vector3 Value; }
	[Game] public class MaxSpawnPerFrame : IComponent { public int Value; }
	[Game] public class SpawnRequestSetting : IComponent { }
}