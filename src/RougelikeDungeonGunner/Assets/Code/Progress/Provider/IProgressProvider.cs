using Code.Progress.Data;

namespace Code.Progress.Provider
{
	public interface IProgressProvider
	{
		ProgressData ProgressData { get; }
		TransientData TransientData { get; }

		LevelData LevelData => TransientData.LevelData;
		HeroData HeroData => TransientData.HeroData;
		ShopData ShopData => TransientData.ShopData;
		WeaponData WeaponData => TransientData.WeaponData;

		void SetProgressData(ProgressData data);
		void SetTransientData(TransientData data);
	}
}