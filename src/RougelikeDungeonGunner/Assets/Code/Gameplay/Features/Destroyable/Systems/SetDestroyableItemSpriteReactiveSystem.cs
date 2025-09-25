using System.Collections.Generic;
using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Destroyable.Systems
{
  public class SetDestroyableItemSpriteReactiveSystem : ReactiveSystem<GameEntity>
  {
    private readonly IStaticDataService _staticDataService;

    public SetDestroyableItemSpriteReactiveSystem(GameContext context, IStaticDataService staticDataService)
      : base(context) =>
      _staticDataService = staticDataService;

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
      return context.CreateCollector(GameMatcher.AllOf(
          GameMatcher.DestroyableItem,
          GameMatcher.DestroyableItemTypeId,
          GameMatcher.SpriteRenderer)
        .Added());
    }

    protected override bool Filter(GameEntity item) =>
      item.isDestroyableItem && item.hasDestroyableItemTypeId && item.hasSpriteRenderer && item.isDestroyed == false;

    protected override void Execute(List<GameEntity> items)
    {
      foreach (GameEntity item in items)
        item.SpriteRenderer.sprite =
          _staticDataService
            .GetDestroyableItemConfig(item.DestroyableItemTypeId).Sprite;

    }
  }
}