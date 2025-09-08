using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo
{
	public class SetAuraSizeSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _auras;

		public SetAuraSizeSystem(GameContext game)
		{
			_auras = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Aura,
					GameMatcher.AuraRadius,
					GameMatcher.Transform));
		}

		public void Execute()
		{
			foreach (GameEntity aura in _auras)
			{
				aura.Transform.localScale = new Vector3(
					aura.AuraRadius, aura.AuraRadius, aura.Transform.localScale.z);
			}
		}
	}
}