using Code.Progress.Data;
using Code.Progress.Data.Progress;
using Code.Progress.Data.Transient;

namespace Code.Progress.Provider
{
	public class ProgressProvider : IProgressProvider
	{
		public ProgressData ProgressData { get; private set; }
		public TransientData TransientData { get; private set; }

		public void SetProgressData(ProgressData data) => 
			ProgressData = data;

		public void SetTransientData(TransientData data) =>
			TransientData = data;
	}
}