using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class EnchantStatsRenderer : MonoBehaviour
	{
		[SerializeField] private EnchantStatsUIHolder _enchantStatsUIHolder;

		private IEnchantStatsUIRenderer _renderer;

		[Inject]
		public void Constructor(IEnchantStatsUIRenderer renderer) => 
			_renderer = renderer;

		private void Start() => 
			RenderStats();

		private void RenderStats() =>
			_renderer.RenderUIStats(_enchantStatsUIHolder);
	}
}