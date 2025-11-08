using Entitas;
using UnityEngine;

namespace Code.Sounds.SoundEffects.Systems
{
	public class SetSoundEffectPitchDependPrechargeTimeSystem : IExecuteSystem
	{
		private readonly ISoundEffectPitchCalculator _pitchCalculator;
		private readonly IGroup<GameEntity> _soundEffects;
		private readonly IGroup<GameEntity> _weapons;

		public SetSoundEffectPitchDependPrechargeTimeSystem(GameContext game, ISoundEffectPitchCalculator pitchCalculator)
		{
			_pitchCalculator = pitchCalculator;
			_soundEffects = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.SoundEffect,
					GameMatcher.AudioClip));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.PrechargeTime));
		}

		public void Execute()
		{
			foreach (GameEntity soundEffect in _soundEffects)
			foreach (GameEntity weapon in _weapons)
			{
				soundEffect.ReplacePitch(
					_pitchCalculator.CalculatePitch(
						weapon.PrechargeTime, soundEffect.AudioClip));

				Debug.Log(soundEffect.Pitch);
			}
		}
	}
}