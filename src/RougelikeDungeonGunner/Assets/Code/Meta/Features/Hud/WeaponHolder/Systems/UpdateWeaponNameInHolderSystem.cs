using System.Collections.Generic;
using Code.Gameplay.Features.Weapon;
using Entitas;

namespace Code.Meta.Features.Hud.WeaponHolder.Systems
{
	public class UpdateWeaponNameInHolderSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _weaponHolders;

		public UpdateWeaponNameInHolderSystem(Contexts contexts) : base(contexts.game) =>
			_weaponHolders = contexts.game.GetGroup(GameMatcher.AllOf(
				GameMatcher.WeaponHolder));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponTypeId)
				.Added());

		protected override bool Filter(GameEntity weapons) =>
			weapons.isWeapon && weapons.hasWeaponTypeId;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
			foreach (GameEntity holder in _weaponHolders)
				holder.WeaponHolder.UpdateWeaponName(FormatWeaponTypeId(weapon.WeaponTypeId));
		}

		private string FormatWeaponTypeId(WeaponTypeId typeId)
		{
			string name = typeId.ToString();

			return System.Text.RegularExpressions.Regex.Replace(name, "(?<!^)([A-Z])", " $1");
		}
	}
}