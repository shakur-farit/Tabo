using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.ObjectPool.Services
{
  public interface IObjectPoolWarmUpper
  {
    UniTask WarmupObjects();
  }
}