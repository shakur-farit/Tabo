using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows.Service;
using Code.Sounds.Music;
using Code.Sounds.Music.Services;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class LevelCompleteFacade : ILevelCompleteFacade
  {
    private readonly IGameStateMachine _stateMachine;
    private readonly IWindowService _windowService;
    private readonly IMusicClipSetter _clipSetter;

    public LevelCompleteFacade(
      IGameStateMachine stateMachine,
      IWindowService windowService,
      IMusicClipSetter clipSetter)
    {
      _stateMachine = stateMachine;
      _windowService = windowService;
      _clipSetter = clipSetter;
    }

    public void EnterNextLevel() =>
      _stateMachine.Enter<BattleEnterState>();

    public void OpenWeaponUpgrade() =>
      _windowService.Open(WindowId.WeaponUpgradeWindow);

    public void OpenWeaponShop() =>
      _windowService.Open(WindowId.WeaponShopWindow);

    public void OpenEnchantShop() =>
      _windowService.Open(WindowId.EnchantShopWindow);

    public void OpenCurrentWeaponInfo() =>
      _windowService.Open(WindowId.CurrentWeaponInfoWindow);

    public void PlayMusic() =>
      _clipSetter.SetClip(MusicTypeId.DungeonMelancholy);
  }
}
  