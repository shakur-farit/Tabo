namespace Code.Gameplay.Features.Hero.Services
{
	public interface ICurrentHeroTypeIdProvider
	{
		HeroTypeId CurrentHeroTypeId { get; set; }
	}
}