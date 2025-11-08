using Code.Infrastructure.Systems;
using Code.Sounds.SoundEffects.Systems;

namespace Code.Sounds.SoundEffects
{
	public sealed class SoundEffectFeature : Feature
	{
		public SoundEffectFeature(ISystemsFactory systems)
		{
			Add(systems.Create<SetSoundEffectPitchDependReloadingTimeSystem>());
			Add(systems.Create<SetSoundEffectPitchDependPrechargeTimeSystem>());
			Add(systems.Create<PlaySoundEffectReactiveSystem>());
		}
	}
}