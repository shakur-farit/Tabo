using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Assets.Code.Meta.Features.Hud.AmmoHolder.Factory
{
	public interface IAmmoUIFactory
	{
		UniTask<GameObject> CreateAmmoUI(Transform parent);
	}
}