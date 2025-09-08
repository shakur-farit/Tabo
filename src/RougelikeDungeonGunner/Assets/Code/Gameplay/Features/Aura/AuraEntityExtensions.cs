namespace Code.Gameplay.Features.Ammo
{
	public static class AuraEntityExtensions
	{
		public static GameEntity AddAuraRequest(this GameEntity entity, AuraTypeId typeId)
		{
			switch (typeId)
			{
				case AuraTypeId.Shield:
					entity.isRequestShield = true;
					break;
				case AuraTypeId.Healing:
					entity.isRequestHealingAura = true;
					break;
			}

			return entity;
		}
	}
}