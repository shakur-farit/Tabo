using Entitas;
using UnityEngine;

namespace Code.Infrastructure.View
{
	public class SetParentForEntityViewSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _children;
		private readonly IGroup<GameEntity> _parents;

		public SetParentForEntityViewSystem(GameContext game)
		{
			_children = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.ViewParent,
					GameMatcher.Transform));

			_parents = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.ParentTransform));
		}

		public void Execute()
		{
			foreach (GameEntity child in _children)
			foreach (GameEntity parent in _parents)
			{
				child.Transform.SetParent(parent.ParentTransform, false);
				child.Transform.position = Vector3.zero;
				child.Transform.localPosition= Vector3.zero;
				Debug.Log(child.Transform.position);
				Debug.Log(child.Transform.localPosition);
			}
		}
	}
}