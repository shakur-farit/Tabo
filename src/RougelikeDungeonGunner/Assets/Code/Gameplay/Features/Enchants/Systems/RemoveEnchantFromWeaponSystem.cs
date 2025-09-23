using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Enchants.Systems
{
	public class RemoveEnchantFromWeaponSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _weapons;

		public RemoveEnchantFromWeaponSystem(Contexts contexts) : base(contexts.game) =>
			_weapons = contexts.game.GetGroup(GameMatcher.AllOf(
				GameMatcher.Weapon,
				GameMatcher.WeaponEnchants));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
				GameMatcher.Enchant,
				GameMatcher.Destructed)
				.NoneOf(GameMatcher.EnchantAlreadyHeld));

		protected override bool Filter(GameEntity entity) => entity.isEnchant && entity.isDestructed;

		protected override void Execute(List<GameEntity> entities)
		{
			foreach (GameEntity enchant in entities)
			{
				int enchantId = enchant.Id;

				foreach (GameEntity weapon in _weapons)
					if (weapon.WeaponEnchants.ContainsKey(enchantId))
						weapon.WeaponEnchants.Remove(enchantId);
			}
		}
	}
}