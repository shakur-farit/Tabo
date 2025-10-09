using Code.Progress.Data.Progress;
using Code.Progress.Data.Transient;

namespace Code.Progress.Provider
{
	public interface IProgressProvider
	{
		ProgressData ProgressData { get; }
		TransientData TransientData { get; }

		HeroData HeroData => TransientData.HeroData;
		WeaponData WeaponData => TransientData.WeaponData;

		void SetProgressData(ProgressData data);
		void SetTransientData(TransientData data);
	}
}