using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using UnityEngine;

namespace Code.Gameplay.Features.Enchants.Behaviours
{
	public class EnchantVisualEffect : MonoBehaviour
	{
		[SerializeField] private SpriteRenderer _spriteRenderer;

		private readonly HashSet<StatusTypeId> _activeEnchantTypes = new();

		public void ApplyVisual(StatusTypeId typeId)
		{
			_activeEnchantTypes.Add(typeId);

			_spriteRenderer.color = _activeEnchantTypes.Count > 1 
				? Color.cyan 
				: GetColorForType(typeId);
		}

		private Color GetColorForType(StatusTypeId typeId)
		{
			return typeId switch
			{
				StatusTypeId.Poison => Color.green,
				StatusTypeId.Freeze => Color.blue,
				StatusTypeId.Flame => Color.red,
				_ => Color.white
			};
		}
	}
}