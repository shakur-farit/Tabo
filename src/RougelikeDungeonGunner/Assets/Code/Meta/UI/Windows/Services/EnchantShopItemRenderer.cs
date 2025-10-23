using System.Collections.Generic;
using Code.Common.Utilities;
using Code.Meta.Features.Shop.Enchant;
using Code.Meta.Features.Shop.Enchant.Factory;
using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class EnchantShopItemRenderer : IEnchantShopItemRenderer
  {
    private readonly IEnchantShopItemFactory _factory;

    public EnchantShopItemRenderer(IEnchantShopItemFactory factory) => 
      _factory = factory;

    public void RenderItems(Transform parent)
    {
      List<EnchantShopItemTypeId> enchantIds = EnumUtility.InitEnumList<EnchantShopItemTypeId>();

      foreach (EnchantShopItemTypeId id in enchantIds)
        _factory.CreateEnchantShopItem(id, parent);
    }
  }
}