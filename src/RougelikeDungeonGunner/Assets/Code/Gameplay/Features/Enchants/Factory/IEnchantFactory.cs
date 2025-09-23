using Code.Gameplay.Features.Statuses;

namespace Code.Gameplay.Features.Enchants.Factory
{
	public interface IEnchantFactory
	{
		GameEntity CreateEnchant(StatusSetup setup, int producerId);
	}
}