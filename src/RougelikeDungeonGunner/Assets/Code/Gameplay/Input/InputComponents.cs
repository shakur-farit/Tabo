using Entitas;
using UnityEngine;

namespace Code.Gameplay.Input
{
	[Input] public class Input : IComponent { }
	[Input] public class AxisInput : IComponent { public Vector2 Value; }
	[Input] public class FireButtonPressed : IComponent { }
	[Input] public class PauseButtonDown : IComponent { }
	[Input] public class WeaponReloadButtonDown : IComponent { }
	[Input] public class StandaloneInput : IComponent { }
	[Input] public class MobileInput : IComponent { }
}