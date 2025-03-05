using Code.Gameplay.Features.TargetCollection;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class FinalizeProcessedAmmoSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _ammo;

		public FinalizeProcessedAmmoSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.Processed));
		}

		public void Execute()
		{
			foreach (GameEntity ammo in _ammo)
			{
				ammo.RemoveTargetCollectionComponents();
				ammo.isDestructed = true;
			}
		}
	}
}