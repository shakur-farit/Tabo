using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Meta.UI.UIRoot.Factory
{
	public interface IHudFactory
	{
		GameObject Hud { get; }
		UniTask<GameObject> CreateHud(Transform parent);
	}
}