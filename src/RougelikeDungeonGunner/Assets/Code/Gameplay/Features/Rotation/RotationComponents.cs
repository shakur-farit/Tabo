using Entitas;

namespace Code.Gameplay.Features.Movement
{
	[Game] public class RotationAngle : IComponent { public float Value; }
	[Game] public class RotationAvailable : IComponent { }
	[Game] public class Rotating : IComponent { }
}