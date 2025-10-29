using Code.Gameplay.Features.Weapon;
using Code.Meta.Features.Shop.Enchant;
using Code.Meta.Features.Shop.Upgrade;
using UnityEngine;

namespace Code.Meta.Features.Shop.Services
{
  public class ShopService : IWeaponShopService, IEnchantShopService, IHeroUpgradeShopService
  {
		public WeaponTypeId WeaponTypeId { get; private set; }
		public Sprite WeaponSprite { get; private set; }
		public int WeaponPrice { get; private set; }

		public EnchantShopItemTypeId EnchantTypeId { get; private set; }
		public Sprite EnchantSprite { get; private set; }
		public int EnchantPrice { get; private set; }

    public HeroUpgradeTypeId HeroUpgradeTypeId { get; private set; }
    public Sprite HeroUpgradeSprite { get; private set; }
    public int HeroUpgradePrice { get; private set; }
    public float HeroUpgradeValue { get; private set; }

    public void SetWeaponSprite(Sprite sprite) => 
			WeaponSprite = sprite;

		public void SetWeaponPrice(int price) => 
			WeaponPrice = price;

		public void SetWeaponTypeId(WeaponTypeId weaponToBuy) => 
			WeaponTypeId = weaponToBuy;

		public void ResetWeaponSetup()
		{
			WeaponTypeId = WeaponTypeId.Unknown;
			WeaponPrice = 0;
			WeaponSprite = null;
		}

		public void SetEnchantSprite(Sprite sprite) =>
			EnchantSprite = sprite;

		public void SetEnchantPrice(int price) =>
			EnchantPrice = price;

		public void SetEnchantTypeId(EnchantShopItemTypeId enchantToBuy) =>
			EnchantTypeId = enchantToBuy;

		public void ResetEnchantSetup()
		{
			EnchantPrice = 0;
			EnchantSprite = null;
		}

    public void SetHeroUpgradeSprite(Sprite sprite) =>
      HeroUpgradeSprite = sprite;

    public void SetHeroUpgradePrice(int price) =>
      HeroUpgradePrice = price;

    public void SetHeroUpgradeTypeId(HeroUpgradeTypeId heroUpgradeType) =>
      HeroUpgradeTypeId = heroUpgradeType;

    public void SetHeroUpgradeValue(float value) => 
      HeroUpgradeValue = value;

    public void ResetHeroUpgradeSetup()
    {
      HeroUpgradePrice = 0;
      HeroUpgradeSprite = null;
    }
  }
}