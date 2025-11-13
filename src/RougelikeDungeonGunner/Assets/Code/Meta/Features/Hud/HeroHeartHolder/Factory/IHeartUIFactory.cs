using UnityEngine;

namespace Code.Meta.Features.Hud.HeroHeartHolder.Factory
{
	public interface IHeartUIFactory
	{
		GameObject CreateHeartUI(Transform parent);
	}
}