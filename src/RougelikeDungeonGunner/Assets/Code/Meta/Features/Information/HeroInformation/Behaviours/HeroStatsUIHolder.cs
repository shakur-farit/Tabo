using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Hero.Configs;
using Code.Meta.Features.Information.HeroInformation.Factory;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Information.HeroInformation.Behaviours
{
	public class HeroStatsUIHolder : MonoBehaviour
	{
		[SerializeField] private Transform _holder;

		private Dictionary<HeroStatUIEntryTypeId, Action<HeroConfig>> _createActions;

		private IHeroStatUIEntryFactory _statUIEntryFactory;

		[Inject]
		public void Constructor(IHeroStatUIEntryFactory statUIEntryFactory)
		{
			_statUIEntryFactory = statUIEntryFactory;

			_createActions = new Dictionary<HeroStatUIEntryTypeId, Action<HeroConfig>>
			{
				[HeroStatUIEntryTypeId.CurrentHp] = config =>
					CreateCurrentHpUiEntry(HeroStatUIEntryTypeId.CurrentHp, _holder, config),
				[HeroStatUIEntryTypeId.MaxHp] = config =>
					CreateMaxHpUiEntry(HeroStatUIEntryTypeId.CurrentHp, _holder, config),
				[HeroStatUIEntryTypeId.MovementSpeed] = config =>
					CreateMovementSpeedUiEntry(HeroStatUIEntryTypeId.CurrentHp, _holder, config)
			};
		}

		public void CreateStatUIEntryItem(HeroStatUIEntryTypeId id, HeroConfig heroConfig)
		{
			Debug.Log(id);

			if (_createActions.TryGetValue(id, out Action<HeroConfig> action))
				action.Invoke(heroConfig);
			else
				throw new Exception($"UI entry with type id {id} does not exist");
		}

		private void CreateCurrentHpUiEntry(HeroStatUIEntryTypeId id, Transform parent,
			HeroConfig heroConfig) =>
			_statUIEntryFactory
				.CreateHeroUIEntryItem(id, parent, heroConfig.CurrentHp.ToString());

		private void CreateMaxHpUiEntry(HeroStatUIEntryTypeId id, Transform parent,
			HeroConfig heroConfig) =>
			_statUIEntryFactory
				.CreateHeroUIEntryItem(id, parent, heroConfig.MaxHp.ToString());

		private void CreateMovementSpeedUiEntry(HeroStatUIEntryTypeId id, Transform parent,
			HeroConfig heroConfig) =>
			_statUIEntryFactory
				.CreateHeroUIEntryItem(id, parent, heroConfig.MovementSpeed.ToString());
	}
}