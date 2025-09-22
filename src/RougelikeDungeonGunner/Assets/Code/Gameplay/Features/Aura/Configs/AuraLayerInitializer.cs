using Assets.Code.Infrastructure.View;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Aura.Configs
{
	public class AuraLayerInitializer : MonoBehaviour
	{
		[SerializeField] private EntityBehaviour _entityBehaviour;

		private void Start()
		{
			if(_entityBehaviour.Entity.hasAuraLayer)
				gameObject.layer = _entityBehaviour.Entity.AuraLayer;
		}
	}
}