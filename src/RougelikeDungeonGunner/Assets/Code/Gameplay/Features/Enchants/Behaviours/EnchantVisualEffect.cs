using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using UnityEngine;

namespace Code.Gameplay.Features.Enchants.Behaviours
{
	public class EnchantVisualEffect : MonoBehaviour
	{
		[SerializeField] private SpriteRenderer _spriteRenderer;
		[SerializeField] private Material _poisonMaterial;
		[SerializeField] private Material _freezeMaterial;
		[SerializeField] private Material _flameMaterial;
		[SerializeField] private Material _combineMaterial;
		[SerializeField] private Material _otherEnchantsMaterial;

		private readonly HashSet<StatusTypeId> _activeEnchantTypes = new();

		public void ApplyVisual(StatusTypeId typeId)
		{
			_activeEnchantTypes.Add(typeId);

			_spriteRenderer.material = _activeEnchantTypes.Count > 1 
				? _combineMaterial
				: GetColorForType(typeId);
		}

		private Material GetColorForType(StatusTypeId typeId)
		{
			return typeId switch
			{
				StatusTypeId.Poison => _poisonMaterial,
				StatusTypeId.Freeze => _freezeMaterial,
				StatusTypeId.Flame => _flameMaterial,
				_ => _otherEnchantsMaterial
			};
		}
	}
}