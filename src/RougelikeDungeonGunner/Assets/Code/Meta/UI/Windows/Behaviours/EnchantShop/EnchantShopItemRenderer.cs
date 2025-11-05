using System.Collections.Generic;
using Code.Common.Utilities;
using Code.Meta.Features.Shop.Enchant;
using Code.Meta.Features.Shop.Enchant.Factory;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.EnchantShop
{
	public class EnchantShopItemRenderer : MonoBehaviour
	{
		[SerializeField] private Transform _holder;

		private IEnchantShopItemFactory _factory;

		[Inject]
		public void Constructor(IEnchantShopItemFactory factory) =>
			_factory = factory;

		private void Start() => 
			RenderItems();

		private void RenderItems()
		{
			List<EnchantShopItemTypeId> enchantIds = EnumUtility.InitEnumList<EnchantShopItemTypeId>();

			foreach (EnchantShopItemTypeId id in enchantIds)
				_factory.CreateEnchantShopItem(id, _holder);
		}
	}
}