using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.Abilities.Factory
{
	public class AbilityFactory : IAbilityFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public AbilityFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreatePistolBulletAbility(int level)
		{
			var abilityLevel = _staticDataService.GetAbilityLevel(AbilityId.PistolBullet, level);

			return CreateEntity.Empty()
				.AddId(_identifier.Next())
				.AddAbilityId(AbilityId.PistolBullet)
				.AddCooldown(abilityLevel.Cooldown)
				.With(x => x.isPistolBullet = true)
				.PutOnCooldown();
		}
	}
}