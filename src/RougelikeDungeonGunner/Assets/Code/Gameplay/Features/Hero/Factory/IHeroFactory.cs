using UnityEngine;

namespace Assets.Code.Gameplay.Features.Hero.Factory
{
	public interface IHeroFactory
	{
		GameEntity CreateHero(HeroTypeId typeId, Vector3 at);
	}
}