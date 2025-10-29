using Code.Gameplay.Common;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows.Service;
using Code.Sounds.Music;
using Code.Sounds.Music.Services;
using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class LevelCompleteWindow : BaseWindow
	{
		[SerializeField] private Button _nextLevelButton;

    private  IGameStateMachine _stateMachine;
    private  IMusicClipSetter _clipSetter;

    [Inject]
    public void Constructor(IGameStateMachine stateMachine, IMusicClipSetter clipSetter)
    {
      Id = WindowId.LevelCompleteWindow;

      _stateMachine = stateMachine;
      _clipSetter = clipSetter;
    }

    protected override void Initialize()
    {
      _nextLevelButton.onClick.AddListener(EnterNextLevel);
      
      PlayMusic();
    }

    private void EnterNextLevel() =>
      _stateMachine.Enter<BattleEnterState>();

    private void PlayMusic() =>
      _clipSetter.SetClip(MusicTypeId.DungeonMelancholy);
  }
}