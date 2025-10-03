using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Music
{
	public sealed class SoundEffectFeature : Feature
	{
		public SoundEffectFeature(ISystemsFactory systems)
		{
			Add(systems.Create<PlaySoundEffectReactiveSystem>());
		}
	}
}