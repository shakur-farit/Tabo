using UnityEngine;

namespace Code.Gameplay.Features.Hero.Behaviours
{
	public class  ColliderHero : MonoBehaviour
	{
		private void OnCollisionEnter2D(Collision2D other) => 
			Debug.Log(other.gameObject.name);
	}
}