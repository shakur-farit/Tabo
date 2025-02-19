using UnityEngine;

namespace Code.Gameplay.Features.Hero.Behaviours
{
	public class AnimatonTester : MonoBehaviour
	{
		public HeroAnimator HeroAnimator;

		private void Update()
		{
			if (UnityEngine.Input.GetKeyDown(KeyCode.W))
			{
				ResetAnimator();
				HeroAnimator.StartMoving();
				HeroAnimator.StartAimUp();
			}
			else if (UnityEngine.Input.GetKeyDown(KeyCode.S))
			{
				ResetAnimator();
				HeroAnimator.StartMoving();
				HeroAnimator.StartAimDown();
			}
			else if (UnityEngine.Input.GetKeyDown(KeyCode.A))
			{
				ResetAnimator();
				HeroAnimator.StartMoving();
				HeroAnimator.StartAimLeft();
			}
			else if (UnityEngine.Input.GetKeyDown(KeyCode.D))
			{
				ResetAnimator();
				HeroAnimator.StartMoving();
				HeroAnimator.StartAimRight();
			}
			else
			{
				ResetAnimator();
				HeroAnimator.StopMoving();
				HeroAnimator.StartIdling();
			}
		}

		private void ResetAnimator()
		{
			HeroAnimator.StopAimDown();
			HeroAnimator.StopAimLeft();
			HeroAnimator.StopAimRight();
			HeroAnimator.StopAimUp();
			HeroAnimator.StopIdling();
			HeroAnimator.StopMoving();
		}
	}
}