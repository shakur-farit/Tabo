using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Collection
{
	[Game] public class TargetsBuffer : IComponent { public List<int> Value; }
	[Game] public class ProcessedTargets : IComponent { public List<int> Value; }
	[Game] public class CollectTargetsInterval : IComponent { public float Value; }
	[Game] public class CollectTargetsTimer : IComponent { public float Value; }
	[Game] public class Radius : IComponent { public float Value; }
	[Game] public class TargetLayerMask : IComponent { public int Value; }

	[Game] public class ForwardCastDistance : IComponent { public float Value; }
	[Game] public class CastStartPositionTransform : IComponent { public Transform Value; }
	[Game] public class CollisionNormal : IComponent { public Vector2 Value; }

	[Game] public class BoxCastWidth : IComponent { public float Value; }
	[Game] public class BoxCastHeight : IComponent { public float Value; }

	[Game] public class ReadyToCollectTargets : IComponent { }
	[Game] public class CollectTargetsContinuously : IComponent { }
	[Game] public class Reached : IComponent { }

	[Game] public class CollisionInFront : IComponent { }
}