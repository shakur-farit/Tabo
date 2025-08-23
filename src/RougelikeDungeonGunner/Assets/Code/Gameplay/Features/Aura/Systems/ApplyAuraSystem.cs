using Entitas;
using Unity.Collections;

namespace Code.Gameplay.Features.Ammo
{
	public class ApplyAuraSystem : IExecuteSystem
	{
		private readonly IAuraFactory _auraFactory;
		private readonly IGroup<GameEntity> _pickupers;

		public ApplyAuraSystem(GameContext game, IAuraFactory auraFactory)
		{
			_auraFactory = auraFactory;
			_pickupers = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AuraPickedUp,
					GameMatcher.AuraTypeId));
		}

		public void Execute()
		{
			foreach (GameEntity pickuper in _pickupers)
			{
				
			}
		}
	}
}