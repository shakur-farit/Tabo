using System;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Levels.Configs
{
	[Serializable]
	public class EnvironmentSetup
	{
		public EntityBehaviour Room;
		public Vector2 HeroStartPosition;
	}
}