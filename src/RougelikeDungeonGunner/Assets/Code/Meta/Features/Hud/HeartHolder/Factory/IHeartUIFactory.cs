using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Meta.Features.Hud.HeartHolder.Factory
{
	public interface IHeartUIFactory
	{
		UniTask<GameObject> CreateHeartUI(Transform parent);
	}
}