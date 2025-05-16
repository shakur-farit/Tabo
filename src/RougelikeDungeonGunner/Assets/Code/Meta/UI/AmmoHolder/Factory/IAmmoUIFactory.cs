using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Meta.UI.AmmoHolder.Factory
{
	public interface IAmmoUIFactory
	{
		UniTask<GameObject> CreateAmmoUI(Transform parent);
	}
}