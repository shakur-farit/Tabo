using System;
using Code.Gameplay.Features.Music.Services;
using UnityEditor.ShaderGraph.Internal;

namespace Code.Gameplay.Features.Music
{
  public enum MusicTypeId
  {
    Unknown = 0,
    ClearedRoom = 1,
    DungeonMelancholy = 2,
    BattleLoopMusic = 3,
    MainMenuMusic = 4,
    BossBattleMusic = 5
  }
}