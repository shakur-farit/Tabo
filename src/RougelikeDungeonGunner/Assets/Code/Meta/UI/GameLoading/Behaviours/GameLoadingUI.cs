using System;
using UnityEngine;

namespace Code.Meta.UI.GameLoading.Behaviours
{
	public class GameLoadingUI : MonoBehaviour
  {
    [SerializeField] private ObjectRotator _rotator;

    public void StartLoading()
		{
			transform.SetParent(null);
			_rotator.Rotate();
			DontDestroyOnLoad(gameObject);
		}
	}
}