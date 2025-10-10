namespace Code.Gameplay.Features.Hero.Services
{
	public class CurrentHeroTypeIdProvider : ICurrentHeroTypeIdProvider
	{
		public HeroTypeId CurrentHeroTypeId { get; set; }
	}
}