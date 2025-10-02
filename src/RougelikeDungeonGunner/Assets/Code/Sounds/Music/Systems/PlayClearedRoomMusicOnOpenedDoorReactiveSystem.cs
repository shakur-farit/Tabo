using System.Collections.Generic;
using Code.Gameplay.Features.Music.Services;
using Entitas;

namespace Code.Gameplay.Features.Music.Systems
{
  public class PlayClearedRoomMusicOnOpenedDoorReactiveSystem : ReactiveSystem<GameEntity>
  {
    private readonly IMusicClipSetter _clipSetter;

    public PlayClearedRoomMusicOnOpenedDoorReactiveSystem(GameContext game, IMusicClipSetter clipSetter) : base(game) => 
      _clipSetter = clipSetter;

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
      context.CreateCollector(GameMatcher.AllOf(
        GameMatcher.Door,
        GameMatcher.Opened).Added());

    protected override bool Filter(GameEntity door) => door.isDoor && door.isOpened;

    protected override void Execute(List<GameEntity> doors)
    {
      foreach (GameEntity door in doors) 
        _clipSetter.SetClip(MusicTypeId.ClearedRoom);
    }
  }
}