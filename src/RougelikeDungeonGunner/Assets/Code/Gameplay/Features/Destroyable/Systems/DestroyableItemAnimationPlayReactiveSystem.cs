using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Systems
{
	public class DestroyableItemAnimationPlayReactiveSystem : ReactiveSystem<GameEntity>
	{
		private readonly GameContext _context;

		public DestroyableItemAnimationPlayReactiveSystem(GameContext context) : base(context) => 
			_context = context;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		{
			return context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.DestroyableTargetsBuffer)
				.Added());
		}

		protected override bool Filter(GameEntity entity) => entity.hasDestroyableTargetsBuffer;

		protected override void Execute(List<GameEntity> collectors)
		{
			foreach (GameEntity collector in collectors)
			{
				Debug.Log(collector.DestroyableTargetsBuffer.Count);

				foreach (int id in collector.DestroyableTargetsBuffer)
				{
					GameEntity destroyable = _context.GetEntityWithId(id);

					if (destroyable.hasDestroyableAnimator)
						destroyable.DestroyableAnimator.PlayDestroy();
				}
			}
		}
	}
}