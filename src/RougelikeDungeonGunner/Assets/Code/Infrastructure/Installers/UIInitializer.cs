using Code.Meta.UI.Windows.Factory;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
	public class UIInitializer : MonoBehaviour, IInitializable
	{
		private IWindowFactory _windowFactory;

		public RectTransform UIRoot;

		[Inject]
		public void Construct(IWindowFactory windowFactory) =>
			_windowFactory = windowFactory;

		public void Initialize() =>
			_windowFactory.SetUIRoot(UIRoot);
	}
}