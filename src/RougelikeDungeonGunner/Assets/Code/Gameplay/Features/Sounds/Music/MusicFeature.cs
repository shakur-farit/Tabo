using Code.Gameplay.Features.Music.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Door
{
  public sealed class MusicFeature : Feature
  {
    public MusicFeature(ISystemsFactory systems)
    {
      Add(systems.Create<PlayClearedRoomMusicOnOpenedDoorReactiveSystem>());
    }
  }
}