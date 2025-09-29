using Code.Gameplay.Features.Door.Behaviours;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Door
{
	[Game] public class Door : IComponent { }
	[Game] public class DoorTypeIdComponent : IComponent { public DoorTypeId Value; }
	[Game] public class DoorPosition : IComponent { public Vector3 Value; }
	[Game] public class DoorAnimatorComponent : IComponent { public DoorAnimator Value; }

	[Game] public class Opened : IComponent { }
}