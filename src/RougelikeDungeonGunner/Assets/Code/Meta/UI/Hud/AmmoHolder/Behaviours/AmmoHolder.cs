using System.Collections.Generic;
using Code.Meta.UI.Hud.AmmoHolder.Factory;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Hud.AmmoHolder.Behaviours
{
	public class AmmoHolder : MonoBehaviour
	{
		[SerializeField] private Transform _holder;

		private List<GameObject> _bulletIcons = new();

		private IAmmoUIFactory _factory;

		[Inject]
		public void Constructor(IAmmoUIFactory factory) =>
			_factory = factory;

		public async void CreateAmmoUI(int count)
		{
			for (int i = 0; i < count; i++)
			{
				GameObject icon = await _factory.CreateAmmoUI(_holder);
				_bulletIcons.Add(icon);
			}
		}

		public void UpdateAmmoUICount(int currentCount)
		{
			for (int i = 0; i < _bulletIcons.Count; i++) 
				_bulletIcons[i].SetActive(i < currentCount);
		}
	}
}