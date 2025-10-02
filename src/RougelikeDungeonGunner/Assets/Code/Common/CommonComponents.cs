using Code.Infrastructure.View;
using Entitas;
using UnityEngine;

namespace Code.Common
{
	[Game, Sounds] public class View : IComponent { public IEntityView Value; }
	[Game, Sounds] public class ViewPath : IComponent { public string Value; }
	[Game, Sounds] public class ViewPrefab : IComponent { public EntityBehaviour Value; }
	[Game, Sounds] public class ViewParent : IComponent { public Transform Value; }

	[Game, Meta, Input, Sounds] public class Destructed : IComponent { }
	[Game, Sounds] public class SelfDestructedTimer : IComponent { public float Value; }

	[Game] public class Parented : IComponent { }
	[Game] public class Unparented : IComponent { }
}