using Cysharp.Threading.Tasks;

namespace Code.Gameplay.StaticData
{
  public interface IStaticDataService
  {
    UniTask Load();
    UniTask Preload();
  }
}