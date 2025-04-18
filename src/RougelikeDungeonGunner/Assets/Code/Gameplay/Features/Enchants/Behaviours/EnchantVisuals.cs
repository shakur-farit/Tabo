using Code.Gameplay.Features.Statuses;
using UnityEngine;

namespace Code.Gameplay.Features.Enchants
{
	public class EnchantVisuals : MonoBehaviour
	{
		[SerializeField] private SpriteRenderer _spriteRenderer;
		private bool _hasEnchant;

		public void ApplyVisual(StatusTypeId typeId)
		{
			switch (typeId)
			{
				case StatusTypeId.Poison:
					ApplyPoison();
					break;
				case StatusTypeId.Freeze:
					ApplyFreeze();
					break;
			}

			Debug.Log(_spriteRenderer.color);
		}

		private void ApplyPoison()
		{
			if (_hasEnchant)
				_spriteRenderer.color = Color.cyan;
			else
			{
				_spriteRenderer.color = Color.green;
				_hasEnchant = true;
			}
		}

		private void ApplyFreeze()
		{
			if (_hasEnchant)
				_spriteRenderer.color = Color.cyan;
			else
			{
				_spriteRenderer.color = Color.blue;
				_hasEnchant = true;
			}
		}
	}
}