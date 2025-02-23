using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.View
{
	public interface IEntityViewFactory
	{
		UniTask<EntityBehaviour> CreateViewForEntity(GameEntity entity);
		EntityBehaviour CreateViewForEntityFromPrefab(GameEntity entity);
	}
}