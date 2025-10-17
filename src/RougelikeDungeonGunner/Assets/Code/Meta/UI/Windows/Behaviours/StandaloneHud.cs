using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class StandaloneHud : BaseWindow
  {
    [Inject]
    public void Constructor()
    {
      Id = WindowId.StandaloneHud;
    }
  }
}