using Cysharp.Threading.Tasks;

namespace Assets.Code.Infrastructure.View.Factory
{
	public interface IEntityViewFactory
	{
		UniTask<EntityBehaviour> CreateViewForEntity(GameEntity entity);
		EntityBehaviour CreateViewForEntityFromPrefab(GameEntity entity);
	}
}