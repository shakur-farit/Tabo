using Code.Gameplay.Features.Weapon.Services;
using Code.Sounds.SoundEffects.Factory;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectBulletSystem : IExecuteSystem
	{
		private readonly IAmmoCountProvider _currentAmmo;
		private readonly ISoundEffectFactory _soundEffectFactory;
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _holders;

		public CollectBulletSystem(
			GameContext game,
			IAmmoCountProvider currentAmmo,
			ISoundEffectFactory soundEffectFactory)
		{
			_currentAmmo = currentAmmo;
			_soundEffectFactory = soundEffectFactory;
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.LootValue,
					GameMatcher.BulletLoot));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.HeroWeapon,
					GameMatcher.CurrentAmmoCount,
					GameMatcher.MaxAmmoCount)
				.NoneOf(GameMatcher.HeroRocketLauncher));

			_holders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AmmoHolder));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			foreach (GameEntity collected in _collected)
			foreach (GameEntity holder in _holders)
			{
				weapon.ReplaceCurrentAmmoCount(weapon.CurrentAmmoCount + collected.LootValue);

				if (weapon.CurrentAmmoCount > weapon.MaxAmmoCount)
					weapon.ReplaceCurrentAmmoCount(weapon.MaxAmmoCount);

				_currentAmmo.SetCurrentAmmoCount(weapon.CurrentAmmoCount);

				holder.AmmoHolder.UpdateAmmoUICount(weapon.CurrentAmmoCount);

				if (collected.hasSoundEffectTypeId)
					_soundEffectFactory.CreateSoundEffect(collected.SoundEffectTypeId);
			}
		}
	}
}