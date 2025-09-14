using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Common.Registrars
{
	public class CastStartPositionRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Transform _castStartPosiotion;

		public override void RegisterComponents() =>
			Entity.AddCastStartPositionTransform(_castStartPosiotion);

		public override void UnregisterComponents()
		{
			if (Entity.hasCastStartPositionTransform)
				Entity.RemoveCastStartPositionTransform();
		}
	}
}