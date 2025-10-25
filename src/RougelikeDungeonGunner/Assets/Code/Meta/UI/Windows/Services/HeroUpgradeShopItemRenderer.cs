using System.Collections.Generic;
using Code.Common.Utilities;
using Code.Meta.Features.Shop.Enchant.Factory;
using Code.Meta.Features.Shop.Upgrade;
using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class HeroUpgradeShopItemRenderer : IHeroUpgradeShopItemRenderer
	{
		private readonly IHeroUpgradeShopItemFactory _factory;

		public HeroUpgradeShopItemRenderer(IHeroUpgradeShopItemFactory factory)
		{
			_factory = factory;
		}

		public void RenderItems(Transform parent)
		{
			List<HeroUpgradeTypeId> enchantIds = EnumUtility.InitEnumList<HeroUpgradeTypeId>();

			foreach (HeroUpgradeTypeId id in enchantIds)
				_factory.CreateHeroUpgradeShopItem(id, parent);
		}
	}
}