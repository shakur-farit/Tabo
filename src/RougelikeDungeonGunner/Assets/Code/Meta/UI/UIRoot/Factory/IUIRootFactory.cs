using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Meta.UI.UIRoot.Factory
{
	public interface IUIRootFactory
	{
		GameObject UIRoot { get; }
		UniTask<GameObject> CreateUIRoot();
	}
}