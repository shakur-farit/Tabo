using UnityEngine;

namespace Code.Meta.Features.Hud.AmmoHolder.Factory
{
	public interface IAmmoUIFactory
	{
		GameObject CreateAmmoUI(Transform parent);
	}
}