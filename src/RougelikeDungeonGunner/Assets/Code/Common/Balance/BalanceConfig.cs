using System;
using UnityEngine;

namespace Code.Common.Balance
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Balance Config", fileName = "BalanceConfig")]
	public class BalanceConfig : ScriptableObject
	{
		public WeaponBalance WeaponBalance;
	}

	[Serializable]
	public class WeaponBalance
	{
		public float MinCooldown;
		public float MinReloadTime;
		public float MinPrechargeTime;
		public int MaxMagazineSize;
		public float MaxSpreadAngle;
		public int MaxEnchantSlots;
	}
}