using System.Collections.Generic;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Destroyable.Systems
{
  public class SetDestroyableItemRuntimeAnimatorControllerReactiveSystem : ReactiveSystem<GameEntity>
  {
    private readonly IStaticDataService _staticDataService;

    public SetDestroyableItemRuntimeAnimatorControllerReactiveSystem(GameContext context, IStaticDataService staticDataService)
      : base(context) =>
      _staticDataService = staticDataService;

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
      return context.CreateCollector(GameMatcher.AllOf(
          GameMatcher.DestroyableItem,
          GameMatcher.DestroyableItemTypeId,
          GameMatcher.DestroyableAnimator)
        .Added());
    }

    protected override bool Filter(GameEntity items) =>
      items.isDestroyableItem && items.hasDestroyableItemTypeId && items.hasDestroyableAnimator;

    protected override void Execute(List<GameEntity> items)
    {
      foreach (GameEntity item in items)
        item.DestroyableAnimator.SetRuntimeAnimatorController(
          _staticDataService
            .GetDestroyableItemConfig(item.DestroyableItemTypeId).AnimatorController);
    }
  }
}