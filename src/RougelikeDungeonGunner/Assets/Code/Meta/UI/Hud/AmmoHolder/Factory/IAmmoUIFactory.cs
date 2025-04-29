using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Meta.UI.Hud.AmmoHolder.Factory
{
	public interface IAmmoUIFactory
	{
		UniTask<GameObject> CreateAmmoUI(Transform parent);
	}
}