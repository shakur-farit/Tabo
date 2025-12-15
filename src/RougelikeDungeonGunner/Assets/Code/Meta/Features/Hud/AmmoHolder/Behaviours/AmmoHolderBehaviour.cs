using System.Collections.Generic;
using Code.Meta.Features.Hud.AmmoHolder.Factory;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Hud.AmmoHolder.Behaviours
{
	public class AmmoHolderBehaviour : MonoBehaviour
	{
		[SerializeField] private Transform _holder;

		private readonly List<GameObject> _bulletIconsBuffer = new();

		private IAmmoUIFactory _factory;

		[Inject]
		public void Constructor(IAmmoUIFactory factory) =>
			_factory = factory;

		public void UpdateAmmoUICount(int currentCount)
		{
			CreateAmmoUI(currentCount);

			for (int i = 0; i < _bulletIconsBuffer.Count; i++)
				_bulletIconsBuffer[i].SetActive(i < currentCount);
		}

		private void CreateAmmoUI(int requiredCount)
		{
			while (_bulletIconsBuffer.Count < requiredCount)
			{
				GameObject icon = _factory.CreateAmmoUI(_holder);
				icon.SetActive(false);
				_bulletIconsBuffer.Add(icon);
			}
		}
	}
}