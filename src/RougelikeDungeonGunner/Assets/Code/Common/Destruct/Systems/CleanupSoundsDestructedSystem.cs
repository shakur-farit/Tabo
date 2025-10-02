using System.Collections.Generic;
using Entitas;

namespace Code.Common.Destruct.Systems
{
  public class CleanupSoundsDestructedSystem : ICleanupSystem
  {
    private readonly IGroup<SoundsEntity> _entities;
    private readonly List<SoundsEntity> _buffer = new(128);

    public CleanupSoundsDestructedSystem(SoundsContext sounds)
    {
      _entities = sounds.GetGroup(SoundsMatcher
        .AllOf(
          SoundsMatcher.Destructed));
    }

    public void Cleanup()
    {
      foreach (SoundsEntity entity in _entities.GetEntities(_buffer))
        entity.Destroy();
    }
  }
}