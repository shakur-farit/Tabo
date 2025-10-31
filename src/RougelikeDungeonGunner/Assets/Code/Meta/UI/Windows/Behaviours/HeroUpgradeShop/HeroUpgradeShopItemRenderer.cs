using System.Collections.Generic;
using Code.Common.Utilities;
using Code.Meta.Features.Shop.Enchant.Factory;
using Code.Meta.Features.Shop.Upgrade;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class HeroUpgradeShopItemRenderer : MonoBehaviour
	{
		[SerializeField] private Transform _holder;

		private IHeroUpgradeShopItemFactory _factory;

		[Inject]
		public void Constructor(IHeroUpgradeShopItemFactory factory) =>
			_factory = factory;

		private void Start() => 
			RenderItems();

		private void RenderItems()
		{
			List<HeroUpgradeTypeId> upgradeTypeIds = EnumUtility.InitEnumList<HeroUpgradeTypeId>();

			foreach (HeroUpgradeTypeId id in upgradeTypeIds)
				_factory.CreateHeroUpgradeShopItem(id, _holder);
		}
	}
}