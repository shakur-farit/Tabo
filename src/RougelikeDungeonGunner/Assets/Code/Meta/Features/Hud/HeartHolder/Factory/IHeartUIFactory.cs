using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Meta.UI.HeartHolder.Factory
{
	public interface IHeartUIFactory
	{
		UniTask<GameObject> CreateHeartUI(Transform parent);
	}
}