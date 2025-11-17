using Code.Infrastructure.Systems;
using Code.Sounds.Music.Systems;

namespace Code.Sounds.Music
{
  public sealed class MusicFeature : Feature
  {
    public MusicFeature(ISystemsFactory systems)
    {
      Add(systems.Create<PlayBossBattleMusicReactiveSystem>());
      Add(systems.Create<PlayClearRoomMusicReactiveSystem>());
    }
  }
}