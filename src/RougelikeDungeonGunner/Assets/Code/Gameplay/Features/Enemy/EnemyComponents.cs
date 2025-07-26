using Code.Gameplay.Features.Enemy.Behaviours;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy
{
	[Game] public class Enemy : IComponent { }
	[Game] public class EnemyTypeIdComponent : IComponent { public EnemyTypeId Value; }
	[Game] public class EnemyAnimatorComponent : IComponent { public EnemyAnimator Value; }

	[Game] public class LastTargetPosition : IComponent { public Vector3 Value; }

	[Game] public class Orc : IComponent { }
	[Game] public class Hedusa : IComponent { }
}