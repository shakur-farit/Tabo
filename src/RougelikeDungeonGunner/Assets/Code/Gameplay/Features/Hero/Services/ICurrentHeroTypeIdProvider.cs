namespace Code.Gameplay.Features.Hero
{
	public interface ICurrentHeroTypeIdProvider
	{
		HeroTypeId CurrentHeroTypeId { get; set; }
	}
}