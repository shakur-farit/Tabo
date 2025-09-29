using Code.Gameplay.Features.Destroyable.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Destroyable
{
	[Game] public class DestroyableItem : IComponent { }
	[Game] public class DestroyableItemTypeIdComponent : IComponent { public DestroyableItemTypeId Value; }
	[Game] public class DestroyableAnimatorComponent : IComponent { public DestroyableAnimator Value; }
	[Game] public class Destroying : IComponent { }
	[Game] public class Destroyed : IComponent { }
}