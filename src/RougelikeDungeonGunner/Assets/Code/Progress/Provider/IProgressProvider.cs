using Code.Progress.Data;

namespace Code.Progress.Provider
{
	public interface IProgressProvider
	{
		ProgressData ProgressData { get; }
		TransientData TransientData { get; }
		void SetProgressData(ProgressData data);
		void SetTransientData(TransientData data);
	}
}