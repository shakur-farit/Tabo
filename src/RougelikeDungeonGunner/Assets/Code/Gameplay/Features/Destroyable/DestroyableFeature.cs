using Code.Gameplay.Features.Destroyable.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Destroyable
{
	public sealed class DestroyableFeature : Feature
	{
		public DestroyableFeature(ISystemsFactory systems)
    {
      Add(systems.Create<CreateWallDestroyableItemReactiveSystem>());
      Add(systems.Create<CreateFloorDestroyableItemReactiveSystem>());
      Add(systems.Create<SetDestroyableItemSpriteReactiveSystem>());
      Add(systems.Create<SetDestroyableItemRuntimeAnimatorControllerReactiveSystem>());
      Add(systems.Create<DestroyableItemDestroyAnimationPlaySystem>());
      Add(systems.Create<MarkDestroyedDestroyableItemOnAnimationEndSystem>());
      Add(systems.Create<MarkDestructDestroyedDestroyableItemEntitySystem>());
    }
  }
}