using Entitas;

namespace Assets.Code.Common.Entity.ToStrings
{
  public interface INamedEntity : IEntity
  {
    string EntityName(IComponent[] components);
    string BaseToString();
  }
}