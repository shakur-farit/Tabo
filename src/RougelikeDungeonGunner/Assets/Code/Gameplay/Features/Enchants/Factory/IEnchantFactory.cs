using Assets.Code.Gameplay.Features.Statuses;

namespace Assets.Code.Gameplay.Features.Enchants.Factory
{
	public interface IEnchantFactory
	{
		GameEntity CreateEnchant(StatusSetup setup, int producerId);
	}
}