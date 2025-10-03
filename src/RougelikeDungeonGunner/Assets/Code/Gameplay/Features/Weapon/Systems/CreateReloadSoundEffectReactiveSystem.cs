using System.Collections.Generic;
using Code.Gameplay.Features.Music;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class CreateReloadSoundEffectReactiveSystem : ReactiveSystem<GameEntity>
	{
		private readonly ISoundEffectFactory _soundEffectFactory;

		public CreateReloadSoundEffectReactiveSystem(GameContext game, ISoundEffectFactory soundEffectFactory) 
			: base(game) => 
			_soundEffectFactory = soundEffectFactory;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
				GameMatcher.Weapon,
				GameMatcher.Reloading,
				GameMatcher.ReloadSoundEffectTypeId).Added());

		protected override bool Filter(GameEntity weapon) =>
			weapon.isWeapon && weapon.isReloading && weapon.hasReloadSoundEffectTypeId;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
				_soundEffectFactory.CreateSoundEffect(weapon.ReloadSoundEffectTypeId);
		}
	}
}