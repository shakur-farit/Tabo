using Code.Gameplay.Features.Enemy.Behaviours;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy
{
	[Game] public class Enemy : IComponent { }
	[Game] public class EnemyTypeIdComponent : IComponent { public EnemyTypeId Value; }
	[Game] public class EnemyAnimatorComponent : IComponent { public EnemyAnimator Value; }
	[Game] public class EnemyTargetSpriteRendererComponent : IComponent { public SpriteRenderer Value; }
	[Game] public class EnemyHpBarComponent : IComponent { public EnemyHpBar Value; }

	[Game] public class ScoreValue : IComponent { public int Value; }

	[Game] public class TargetDetectingRadius : IComponent { public float Value; }
	[Game] public class TargetDetected : IComponent { }
	[Game] public class LastTargetPosition : IComponent { public Vector3 Value; }

	[Game] public class Boss : IComponent { }
}